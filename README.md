2.1.1 Практическая работа «введение в объектно-ориентированное программирование»
В рамках работы студенту необходимо разработать программу, формирующую программный объект на основании его описания в виде текстовой строки. 
В строке задается тип объекта и его свойства. Свойства могут иметь различные типы данных (целый, дробный, строковый, дата, время). Строковые
свойства выделяются кавычками. Дата описывается в формате гггг.мм.дд и записывается без кавычек. Время описывается в формате чч:мм.
Друг от друга свойства отделяются группой из одного или более пробелов.
Разработанная программа должна корректно обрабатывать различные варианты корректных входных данных (обработку ошибок можно не выполнять)
Вариант 12
Недвижимость: владелец (строка), дата постановки на учет, ориентировочная стоимость (целое).

2.1.2 Рефакторинг кода (разбиение на функции). Системы контроля версий git
Исходный код предыдущей работы надо поместить в git-репозиторий.
После этого доработать этот код в соответствии с заданием и добавить изменения в этот же репозиторий.
Задание заключается в:
1. добавлении в программу поддержку 2 новых типов объектов, связанных с исходным. Новые объекты студент может придумать сам, они должны обладать новыми полями разных типов.
Например, если исходный объект «Доходы», то новыми объектами могут быть «Доходы организации»
или «Типизированные доходы» (хранящие помимо источника информацию о типе операции, в результате которой они получены).
3. добавлении возможности обработки набора объектов, записанных в виде строки или в файле.
4. улучшении программы в части разбиения исходного кода на более простые функции.
Исходный код должен быть отформатирован в соответствии с одним из популярных соглашений о кодировании - например, соглашении компании Google.
Функции программы должны соответствовать принципу SRP.

2.1.3 Рефакторинг кода (декомпозиция на классы) и обработка ошибок
Работа заключается в улучшении программы работы 2 в части выделения вспомогательных классов, обработки исключительных ситуаций и покрытии 
созданного кода тестами. Программа должна корректно обрабатывать не только корректные входные строки, но и некорректные.




