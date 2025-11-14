FROM mysql:5.7.22
EXPOSE 3306
COPY ./ASP-NETRest/db/migrations /home/database/
COPY ./ASP-NETRest/db/dataset /home/database/
COPY ./ASP-NETRest/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh