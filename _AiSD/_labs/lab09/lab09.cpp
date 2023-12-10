#include <iostream>
#include<vector>
#include<algorithm>
#include <limits.h>
#include <Windows.h>
#include <random>
using namespace std;


#define V 5
//#define V 8

int childsNumber = 0;
int populationSize = 0;
int evolutionCirclsNumber = 0;
vector<int> nodes = { 1, 2, 3, 4, 5, 6, 7 };


int map[V][V] = { { INT_MAX, 25, 40, 31, 27},
				{ 5, INT_MAX, 17, 30, 25},
				{ 19, 15, INT_MAX, 6, 1},
				{ 9, 50, 24, INT_MAX, 6 },
				{ 22, 8, 7, 10, INT_MAX },
};

//int map[V][V] = { {INT_MAX, 50, 60, 20, 20, 30, 10, 70},
//				{50, INT_MAX, 10, 90, 70, 20, 35, 10},
//				{60, 10, INT_MAX, 20, 70, 40, 30, 70},
//				{20, 90, 20, INT_MAX, 20, 70, 80, 25},
//				{20, 70, 70, 20, INT_MAX, 60, 70, 25},
//				{30, 20, 40, 70, 60, INT_MAX, 20, 70},
//				{10, 35, 30, 80, 70, 20, INT_MAX, 40},
//				{70, 10, 70, 25, 25, 70, 40, INT_MAX}
//};


struct individual {
	string genome;
	int adaptability;
};


int generateRandomNumber(int start, int end)
{
	std::random_device rd;  // Создаем объект random_device для генерации случайного начального значения
	std::mt19937 gen(rd());  // Инициализируем генератор случайных чисел с использованием случайного начального значения
	std::uniform_int_distribution<int> dist(start, end);  // Определение диапазона случайных чисел

	return dist(gen);
}


bool isCorrect(string s, char ch)
{
	for (int i = 0; i < s.size(); i++) {
		if (s[i] == ch)
			return false;
	}
	//for (int i = 1; i < s.size(); i++) {
	//	if (map[s[i] - 48][ch - 48] == INT_MAX)
	//		return false;
	//}
	if (map[s[s.size() - 1] - 48][ch - 48] == INT_MAX) {
		return false;
	}
	return true;
}


//меняем местами два рандомных гена
string mutatedGene(string genome)
{
	while (true) {
		int g1 = generateRandomNumber(1, V);
		int g2 = generateRandomNumber(1, V);

		if (g2 != g1) {
			char temp = genome[g1];
			genome[g1] = genome[g2];
			genome[g2] = temp;

			break;
		}
	}
	return genome;
}

string createGenome()
{
	vector<int> n = nodes;
	string genome = "0";
	while (true) {
		if (genome.size() == V) {
			genome += genome[0];
			break;
		}
		int t;
		if (n.size() == 1) {
			t = 0;
		}
		else {
			t = generateRandomNumber(0, n.size() - 1);
		}
		int temp = n[t];
		if (isCorrect(genome, (char)(temp + 48))) {
			genome += (char)(temp + 48);
			n.erase(n.begin() + t);
		}
	}
	return genome;
}

int calculateAdaptability(string genome)
{
	int distance = 0;

	// Проходим по каждому гену в геноме
	for (int i = 0; i < genome.size() - 1; i++) {
		// Проверяем, что между текущим и следующим городом есть допустимое расстояние
		if (map[genome[i] - 48][genome[i + 1] - 48] == INT_MAX)
			return INT_MAX; // Если расстояние между городами слишком велико, вернуть максимальное значение

		// Добавляем расстояние между текущим и следующим городом к общей приспособленности
		distance += map[genome[i] - 48][genome[i + 1] - 48];
	}

	return distance; // Возвращаем общую приспособленность генома (сумму расстояний)
}


bool compareAdapdability(struct individual t1, struct individual t2)
{
	return t1.adaptability < t2.adaptability;
}

void doGeneticAlgorithm(int map[V][V])
{
	vector<struct individual> population;
	struct individual temp;

	for (int i = 0; i < populationSize; i++) {
		temp.genome = createGenome();
		temp.adaptability = calculateAdaptability(temp.genome);
		population.push_back(temp);
	}

	cout << "\nСтартовая популяция: " << endl;
	cout << "Геном популяци \tвес генома\n";
	for (int i = 0; i < populationSize; i++)
		cout << population[i].genome << "\t\t"
		<< population[i].adaptability << endl;
	cout << "\n";


	sort(population.begin(), population.end(), compareAdapdability);


	int circl = 1;
	while (circl <= evolutionCirclsNumber) {
		cout << endl << "Лучший геном: " << population[0].genome;
		cout << " его вес: " << population[0].adaptability << "\n\n";

		vector<struct individual> new_population;

		for (int i = 0; i < childsNumber; i++) {

			//берем родителя с лучшими генами
			struct individual parent1 = population[i];
			struct individual parent2 = population[i + 1];

			while (true)
			{
				string new_genome = mutatedGene(parent1.genome);
				struct individual new_gene;
				new_gene.genome = new_genome;
				new_gene.adaptability = calculateAdaptability(new_gene.genome);

				//проверка стала ли дистанция меньше после мутации
				if (new_gene.adaptability <= population[i].adaptability) {
					new_population.push_back(new_gene);
					break;
				}
				else {
					new_gene.adaptability = INT_MAX;
					new_population.push_back(new_gene);
					break;
				}
			}
		}

		for (int i = 0; i < childsNumber; i++)
		{
			population.push_back(new_population[i]);
		}
		sort(population.begin(), population.end(), compareAdapdability);

		for (int i = 0; i < childsNumber; i++)
		{
			population.pop_back();
		}

		cout << "Поколение " << circl << " \n";
		cout << "Геном популяци \tвес генома\n";

		for (int i = 0; i < populationSize; i++)
			cout << population[i].genome << "\t\t"
			<< population[i].adaptability << endl;
		circl++;
	}
	cout << "\n\nнаиболее оптимальный маршрут, найденный генетическим алгоритмом с текущими параметрами: ";
	cout << population[0].genome;
	cout << "\n\n";
}

int main()
{
	setlocale(LC_ALL, "ru");
	cout << "Введите размер популяций: "; cin >> populationSize;
	cout << "Введите количество потомков в одной популяции: "; cin >> childsNumber;
	cout << "Введите количество эволюционных циклов: "; cin >> evolutionCirclsNumber;
	doGeneticAlgorithm(map);
}