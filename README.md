### Проведённый рефакторинг

Вынес проверку совпадения строки в отдельный метод IsMatch (Extract Method)

В целом разделил метод FindSubstring на поиск и сравнение (Split Method)

Был нарушен SRP принцип, поэтому разделил Prjgram на 2 класса, вынес из него логику (Extract Class)

Переименовал FindSubstring в FindIndexOfSubstring, потому что он ищет и выдаёт индекс (Rename Method)

Добавил тесты, они успешно пройдены:

![alt_text](https://github.com/RogaJedi/refactoring_tasks/blob/second/изображение_2025-10-05_211629785.png)
