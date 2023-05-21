# UdemyMicroservices

Microservice'ler arasında senkron ve asenkron iletişim nasıl kurulur öğreneceksiniz.

Microservice mimaride  OAuth 2.0 ve OpenID Connect protokollerinin nasıl implement edileceğiniz öğreniyor olacaksınız.

Microservice'lere ait veritabanlarında tutarlılığı sağlamak için Eventual Consistency model'inin nasıl uygulanacağını öğreneceksiniz.

Microservice'lerimizi nasıl dockerize edileceğini öğreneceksiniz.

Docker Compose dosyasının nasıl oluşturulacağını öğreneceksiniz.

Çeşitli veritabanlarını container olarak nasıl ayağa kaldırılacağını öğreniyor olacaksınız.

Kursta, udemy benzeri bir online kurs satış platformunu microservice mimari ile geliştiriyor olacağız.

Microservices :

Catalog Microservice

Kurslarımız ile ilgili bilgilerin tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.

MongoDb (Veritabanı)

One-To-Many/One-To-One ilişki

MongoDb

Basket Microservice

Sepet işlemlerinden sorumlu olacak mikroservisimiz.

RedisDB(Veritabanı)

Discount Microservice

Kullanıcıya tanımlanacak indirim kuponlarından sorumlu olacak mikroservisimiz.

PostgreSQL(Veritabanı)

Order Microservice

Sipariş işlemlerinden sorumlu olacak mikroservisimiz.

Bu mikroservisimizde Domain Driven Design yaklaşımını kullanarak geliştiriyor olacağız.

Bu mikroservisimizde CQRS tasarım kalıbını uygulamak için MediatR kütüphanesini kullanıyor olacağız.

Sql Server(Veritabanı)

Domain Driven Design

CQRS (MediatR Libarary)

FakePayment Microservice

Ödeme işlemlerinden sorumlu olacak mikroservisimiz.

IdentityServer Microservice

Sql Server(Veritabanı)

Kullanıcı dataların tutulmasından,token ve refreshtoken üretilmesinden sorumlu olacak microservisimiz.

PhotoStock Microservice

Kurs fotograflarının tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.

API Gateway

Ocelot Library

Message Broker

Mesaj kuyruk sistemi olarak RabbitMQ kullanıyor olacağız.

RabbitMQ ile haberleşmek için MassTransit kütüphanesini kullanıyor olacağız.

RabbitMQ (MassTransit Library)

Identity Server

Token / RefreshToken üretmek

Access Token ile microservice'lerimizi korumak

OAuth 2.0 / OpenID Connect protokollerine uygun yapı inşa etmek

Asp.Net Core MVC Microservice

Microservice'lerden almış olduğu dataları kullanıcıya gösterecek ve kullanıcı ile etkileşime geçmekten sorumlu olacak UI mikroservisimiz

Öğrenecekleriniz
.Net 5.0 ile Microservice Architecture
Asynchronous and Aynchronous between Microservices
API Gateway ( Ocelot Libarary)
RabbitMQ
Docker & Docker Compose
IdentityServer4
AccessToken/RefreshToken
Domain Driven Design
CQRS Pattern
PostgreSQL
MongoDB
SqlServer
