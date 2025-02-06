# Как это работает?

Всё что нужно сделать для начала работы с этим проектом - это запустить docker-compose в директории с файлом docker-compose.yml.
В этом файле прописана вся логика создания необходимых контейнеров и связей между ними.
Директории frontend и backend имеют свой Dockerfile в котором прописаны команды для сборки проектов.
![Screenshot 2025-02-06 143734](https://github.com/user-attachments/assets/9c6906ef-bc80-4d26-a14a-26a0691ad64e)


# Что делает проект?

После успешного развертывания контейнеров в докере у Вас появится доступ к следующим ресурсам:

http://localhost - сайт на реакте, расположеный в папке frontend проекта
![Screenshot 2025-02-06 143607](https://github.com/user-attachments/assets/fb7cd615-6d0a-45de-bc68-19ef16519829)

http://localhost:5000/ либо же http://localhost/api/ - доступ к backend API на ASP.NET Core, который включает в себя создание подключения к базе данных mySQL mariaDB, созданной в отдельном контейнере. (Никакие данные в базу данных код не записывает, просто создает подключение чтобы показать работоспособность)

![Screenshot 2025-02-06 143629](https://github.com/user-attachments/assets/3de3b674-2457-4850-8c1c-fb09de18a744)

http://localhost:8086 - доступ к influxdb
![Screenshot 2025-02-06 143659](https://github.com/user-attachments/assets/73873fa3-9284-40cc-b2c0-45db035ad453)

http://localhost:3000 - доступ к grafana
![Screenshot 2025-02-06 143651](https://github.com/user-attachments/assets/ccb64ca1-dd05-40f7-9864-504c38b34d02)

http://localhost:8080 - доступ к phpMyAdmin
![Screenshot 2025-02-06 143641](https://github.com/user-attachments/assets/61d70d03-168f-4a77-9f7d-c6d87ccc6438)

Доступ к frontend и backend частям производится с помощью nginx, конфигурация которого находится в одноименной директории.
