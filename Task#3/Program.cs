graph TD;
    A[Начало] --> B["Введите элементы массива через запятую:"];
    B[input] --> C[originalArray = input.Split(',')];
    C[originalArray] --> D[FilterArray(originalArray)];
    D[FilterArray(originalArray)] --> E[result];
    E[result = new string] --> F["Новый массив:"];
    G[Конец];