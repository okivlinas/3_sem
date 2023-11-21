// Создаем пустой WeakMap
const cache = new WeakMap();

// Функция для кэширования результатов
function cachedFunction(func) {
  return function(...args) {
    // Проверяем, есть ли результат для данного набора аргументов в кэше
    if (cache.has(func) && cache.get(func)[args]) {
      console.log('Данные взяты из кэша');
      return cache.get(func)[args];
    }

    // Выполняем функцию, так как результатов в кэше нет
    const result = func(...args);

    // Создаем новый кэш для функции, если его еще нет
    if (!cache.has(func)) {
      cache.set(func, {});
    }

    // Сохраняем результат в кэше
    cache.get(func)[args] = result;

    console.log('Результаты вычислений сохранены в кэше');
    return result;
  };
}

// Пример функции, которую будем кэшировать
function calculateExpensiveValue(base, exponent) {
  console.log('Выполняется вычисление...');
  return Math.pow(base, exponent);
}

// Создаем кэшированную версию функции
const cachedCalculate = cachedFunction(calculateExpensiveValue);

// Пример использования
console.log(cachedCalculate(2, 3)); // Выполняется вычисление... 8
console.log(cachedCalculate(2, 3)); // Данные взяты из кэша 8
console.log(cachedCalculate(4, 2)); // Выполняется вычисление... 16
console.log(cachedCalculate(4, 2)); // Данные взяты из кэша 16