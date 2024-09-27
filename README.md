Computer graphics lab4

Программа должна содержать следующие возможности:

* Создание полигонов через клики мышью. Точка и ребро считаются полигонами с одной и двумя вершинами соответственно.
* Очистка сцены (удаление всех полигонов).
* Применение аффинных преобразований к полигону (Все преобразования должны быть реализованы матрицами!):
    * Смещение на dx, dy
    * Поворот вокруг заданной пользователем точки
    * Поворот вокруг своего центра
    * Масштабирование относительно заданной пользователем точки
    * Масштабирование относительно своего центра
* Поиск точки пересечения двух ребер (добавление второго ребра мышкой, динамически).
* Проверка принадлежит ли заданная пользователем (с помощью мыши) точка выпуклому и невыпуклому полигонам
* Классифицировать положение точки относительно ребра (справа или слева)

N.B. Проверка очередной точки или ребра в последних трёх пунктах не должна требовать очистки экрана, перерисовки полигона, повторного выбора инструмента и т.п.
