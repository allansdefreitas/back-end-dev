FROM eclipse-temurin:8-jdk

RUN groupadd -r spring && useradd -r -g spring spring

USER spring:spring

ARG JAR_FILE=target/*.jar
COPY ${JAR_FILE} app.jar

ENTRYPOINT ["java","-Xms128M","-Xmx128M","-Dspring.profiles.active=prod","-jar","/app.jar"]