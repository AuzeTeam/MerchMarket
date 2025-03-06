# 🛍️ Онлайн-маркетплейс мерча с CRM-системой

## 📖 О проекте

Онлайн-маркетплейс мерча предоставляет пользователям удобный интерфейс для заказа товаров, а также включает CRM-систему для администраторов, которая позволяет управлять каталогом товаров: добавлять, удалять и изменять их.

## 🛠️ Технологии

### 🌐 Frontend:
- **Vue.js**: основной фреймворк для создания пользовательского интерфейса.
- **Libraries**: дополнительные библиотеки для расширения функциональности Vue.js, такие как:
  - **Pinia**: для управления состоянием приложения.
  - **Vue Router**: для маршрутизации.
  - **Axios**: для работы с HTTP-запросами.
  - И другие.

### ⚙️ Backend(**ПЕРЕПИСЫВАЕТСЯ НА С#**):
- **FastAPI**: высокопроизводительный веб-фреймворк для создания API.
- **SQLAlchemy**: объектно-реляционное отображение (ORM), позволяющее работать с базами данных через Python.
- **Pydantic**: библиотека для проверки и сериализации данных, широко используемая в FastAPI.
- **Libraries**: дополнительные библиотеки для различных задач, таких как аутентификация, работа с файлами, отправка уведомлений и прочее.

## 🚀 Функционал

### 🛒 Маркетплейс:
- Каталог товаров.
- Личный кабинет покупателя.
- Система поиска и фильтрации товаров.
- Избранные предметы.

### 🛠️ CRM-система:
- Добавление новых товаров.
- Редактирование существующих товаров.
- Удаление товаров.

## 🔧 Установка и запуск

### 📦 Фронтенд:
```bash
cd Front
npm install
npm run serve
```

### 📦 Бэкенд:
```bash
cd Back
pip install -r requirements.txt
uvicorn app.main:app
or
fastapi dev main.py
```

## 📬 Контакты

Для вопросов и предложений обращайтесь по адресу [telegram: @n1_3ro](https://t.me/n1_3ro)
