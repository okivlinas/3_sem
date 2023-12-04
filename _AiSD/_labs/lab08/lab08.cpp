#include <iostream>
#include <vector>

struct Item {
    int weight;
    int value;
};

void knapsack(const std::vector<Item>& items, int W) {
    int n = items.size();
    std::vector<std::vector<int>> dp(n + 1, std::vector<int>(W + 1, 0));
    std::vector<std::vector<bool>> selected(n + 1, std::vector<bool>(W + 1, false));

    for (int i = 1; i <= n; ++i) {
        for (int w = 1; w <= W; ++w) {
            if (items[i - 1].weight <= w) {
                int newValue = items[i - 1].value + dp[i - 1][w - items[i - 1].weight];
                if (newValue > dp[i - 1][w]) {
                    dp[i][w] = newValue;
                    selected[i][w] = true;
                }
                else {
                    dp[i][w] = dp[i - 1][w];
                    selected[i][w] = false;
                }
            }
            else {
                dp[i][w] = dp[i - 1][w];
                selected[i][w] = false;
            }
        }
    }

    std::vector<Item> selectedItems;
    int i = n, w = W;
    while (i > 0 && w > 0) {
        if (selected[i][w]) {
            selectedItems.push_back(items[i - 1]);
            w -= items[i - 1].weight;
        }
        --i;
    }

    std::cout << "Предметы, включенные в рюкзак:\n";
    for (int i = selectedItems.size() - 1; i >= 0; --i) {
        std::cout << "Вес: " << selectedItems[i].weight << ", Значение: " << selectedItems[i].value << std::endl;
    }

    std::cout << "Максимальная ценность: " << dp[n][W] << std::endl;
}

int main() {
    setlocale(LC_ALL, "rus");
    std::vector<Item> items = {
        {35, 35},
        {20, 20},
        {15, 15}
    };
    int maxWeight;
    std::cin >> maxWeight;

    knapsack(items, maxWeight);

    return 0;
}