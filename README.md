# Космическая колония

## Описание

"Космическая колония" — это концептуальная многопользовательская игра, в которой игроки могут строить свои колонии, исследовать новые планеты, собирать ресурсы и взаимодействовать с другими игроками и NPC. Игра сочетает в себе элементы строительства, исследования и взаимодействия, создавая уникальный игровой опыт.

## Структура проекта

Проект состоит из нескольких компонентов, каждый из которых написан на своем языке программирования:

- **Серверная часть**: реализована на Rust и отвечает за управление игровым состоянием и обработку сетевых запросов.
- **Клиентская часть**: написана на C# для обработки запросов к серверу.
- **Скрипты**: написаны на Lua для управления поведением NPC и игровыми механизмами.
- **Модули**: реализованы на C++ и C для выполнения производительных расчетов и низкоуровневых математических операций.

## Установка

1. Убедитесь, что у вас установлен [Git](https://git-scm.com/) и [Rust](https://www.rust-lang.org/).
2. Клонируйте репозиторий:

```bash
git remote add origin https://github.com/GeorgiyKon/CosmicColony.git
