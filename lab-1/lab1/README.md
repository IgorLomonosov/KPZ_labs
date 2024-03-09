# Принципи що були використані:

## 1. Принцип "DRY" (Don't Repeat Yourself):
Код має уникати повторення, інкапсулюючи логіку в функції, класи чи інші структури. У класі [Product](./lab1/ClassLibrary/Product.cs#L40-L49) та [Warehouse](./lab1/ClassLibrary/Warehouse.cs#L36-L48) використано конструктор та метод SetItemDetails для уникнення повторення коду при ініціалізації об'єктів.

## 2. Принцип "KISS" (Keep It Simple, Stupid):
Код має бути простим і легким для розуміння. Наприклад, методи [DisplayItemDetails](./lab1/ClassLibrary/Warehouse.cs#L18-L23) та [UpdateQuantity](./lab1/ClassLibrary/Warehouse.cs#L25-L34) в класі Warehouse реалізовані просто та чітко без зайвих складнощів.

## 3. Принципи "SOLID" (Single Responsibility Principle):
* ### Single Responsibility Principle (Принцип єдиної відповідальності): 
Класи [Money](./lab1/ClassLibrary/Money.cs#L3), [Product](./lab1/ClassLibrary/Product.cs#L3), [Warehouse](./lab1/ClassLibrary/Warehouse.cs#L3), та [Reporting](./lab1/ClassLibrary/Reporting.cs#L3) виконують лише одну відповідальність.
* ### Open/Closed Principle (Принцип відкритості/закритості): 
Є можливість розширення функціоналу без зміни вже існуючого коду, наприклад, додавання нових типів товарів або методів в клас [Reporting](./lab1/ClassLibrary/Reporting.cs#L3).

## 4. Принцип "YAGNI" (You Ain't Gonna Need It):
Код має включати лише той функціонал, який насправді потрібен, а не той, який може бути потрібний в майбутньому. У коді класу [Reporting](./lab1/ClassLibrary/Reporting.cs#L3) не включено непотрібний функціонал.

## 5. Composition Over Inheritance:
Клас [Warehouse](./lab1/ClassLibrary/Warehouse.cs#L7) містить екземпляр класу [Money](./lab1/ClassLibrary/Money.cs#L3) для отримання функціоналу замість успадкування.

## 6. Fail Fast:
Використання обробки винятків в методах [SetMoneyParts](./lab1/ClassLibrary/Money.cs#L28-L37), [SetProduct](./lab1/ClassLibrary/Product.cs#L40-L49), [UpdateQuantity](./lab1/ClassLibrary/Warehouse.cs#L25-L34), та інших для швидкого виявлення помилок.

Кожен з цих принципів допомагає створювати більш зрозумілий, підтримуваний та масштабований код, підвищуючи його якість та обслуговуваність.
