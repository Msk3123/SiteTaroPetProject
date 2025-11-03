# Tarot Card Management System

Система управління колодою Таро з повним стеком (.NET Backend + React Frontend)

## Структура проекту

```
SiteTaroPetProject/
├── backend/                    # .NET ASP Core API
│   ├── backend/               # Головний API проект
│   │   ├── Controllers/       # API контролери
│   │   ├── MappingProfile.cs  # Конфігурація AutoMapper
│   │   └── Program.cs         # Точка входу
│   ├── Entities/              # Моделі та DTO
│   │   ├── Models/            # Сутності бази даних
│   │   └── DTO/              # Об'єкти передачі даних
│   ├── Repository/            # Репозиторії
│   ├── Contracts/             # Інтерфейси
│   └── Services/              # Бізнес-логіка
└── frontend/                   # React додаток
    ├── public/                # Статичні файли
    └── src/
        ├── components/        # React компоненти
        ├── hooks/            # Власні хуки
        ├── services/         # API сервіси
        ├── App.js            # Головний компонент
        └── index.js          # Точка входу

```

## Backend

### Технології
- .NET 9.0 ASP Core
- Entity Framework Core 9.0
- AutoMapper 15.0.1
- SQL Server

### Запуск Backend

```bash
cd backend/backend
dotnet restore
dotnet build
dotnet run
```

API буде доступний за адресою: `https://localhost:7240`

### API Endpoints

- `POST /api/CartTaro` - Створити нову карту Таро
- `GET /api/CartTaro` - Отримати всі карти
- `GET /api/CartTaro/{id}` - Отримати карту за ID
- `DELETE /api/CartTaro/{id}` - Видалити карту

### Модель даних

```csharp
public class CartTaro
{
    public int Id { get; set; }
    public string Name { get; set; }              // Назва карти
    public string UprightMeaning { get; set; }    // Пряме значення
    public string ReversedMeaning { get; set; }   // Перевернуте значення
    public string Keywords { get; set; }          // Ключові слова
}
```

## Frontend

### Технології
- React 18.2
- React Scripts 5.0.1

### Запуск Frontend

```bash
cd frontend
npm install
npm start
```

Додаток буде доступний за адресою: `http://localhost:3000`

### Структура компонентів

- **App.js** - Головний компонент з header
- **MainPage.jsx** - Головна сторінка
- **CartTaroForm.js** - Форма створення карти Таро
- **useTaroForm.js** - Власний хук для управління станом форми
- **taroService.js** - Сервіс для API запитів

### Особливості

- Використовується PascalCase для полів форми (відповідає .NET конвенціям)
- Валідація обов'язкових полів (Name, UprightMeaning)
- Стилізація з градієнтами та анімаціями
- Обробка помилок та станів завантаження

## Налаштування

### Підключення до бази даних

Відредагуйте `backend/backend/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=FortuneTellingDB;..."
  }
}
```

### CORS

Backend налаштований на прийняття запитів з:
- `http://localhost:3000`
- `https://localhost:3000`

## Розробка

### Додавання нових полів

1. Оновіть модель `CartTaro` в `backend/Entities/Models/CardTaroModel.cs`
2. Оновіть DTO в `backend/Entities/DTO/Data.cs`
3. Оновіть форму в `frontend/src/components/CartTaroForm.js`
4. Оновіть хук в `frontend/src/hooks/useTaroForm.js`

### Міграції бази даних

```bash
cd backend/backend
dotnet ef migrations add MigrationName
dotnet ef database update
```

## Ліцензія

Навчальний проект
