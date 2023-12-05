//task_04
const cache = new WeakMap();

function cachedFunction(func) {
  return function(...args) {
    if (cache.has(func) && cache.get(func)[args]) {
      console.log('Данные взяты из кэша');
      return cache.get(func)[args];
    }

    const result = func(...args);

    if (!cache.has(func)) {
      cache.set(func, {});
    }

    cache.get(func)[args] = result;

    console.log('Результаты вычислений сохранены в кэше');
    return result;
  };
}

function calculateExpensiveValue(base, exponent) {
  console.log('Выполняется вычисление...');
  return Math.pow(base, exponent);
}

const cachedCalculate = cachedFunction(calculateExpensiveValue);

console.log(cachedCalculate(2, 3)); // Выполняется вычисление... 8
console.log(cachedCalculate(2, 3)); // Данные взяты из кэша 8
console.log(cachedCalculate(4, 2)); // Выполняется вычисление... 16
console.log(cachedCalculate(4, 2)); // Данные взяты из кэша 16