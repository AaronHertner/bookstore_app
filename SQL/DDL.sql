-- This file contains all DDL statements used for the application --

create table authors
(
	name varchar(30),
	email varchar(40) not null,
	address varchar(30),
	account_num integer not null,
	royalties double,
	primary key(email, account_num)
);

create table books
(
	title varchar(30) not null,
	author varchar(30),
	pages integer,
	genre varchar(20),
	publisher varchar(30),
	price numeric(5,2),
	book_id varchar(4),
	owner varchar(30),
	primary key (book_id),
	foreign key (owner) references owner
);

create table books_in_cart
(
	user_id integer not null,
	book_id varchar(4) not null,
	quantity integer,
	primary key(user_id, book_id),
	foreign key (user_id) references users,
);

create table logins
(
	email varchar(30) not null,
	password varchar(18) not null,
	store_owner boolean,
	primary key (email),
);

create table orders
(
	order_num serial,
	user_id integer not null,
	title varchar(30),
	author varchar(30),
	pages integer,
	genre varchar(15),
	order_Date date,
	primary key(order_num),
	foreign key(user_id) references users
);

create table owner
(
	balance double,
	email varchar(120) not null,
	foreign key (email) references logins,
);

create table owner_book_reports
(
	owner varchar(120) not null,
	title varchar(30),
	book_id varchar(4),
	copies_sold integer,
	money_made double,
	primary key(owner, book_id),
	foreign key (book_id) references books
);

create table phone_number
(
	email varchar(40) not null,
	account_num integer,
	phone_num varchar(10),	
	primary key(phone_num, email),
	foreign key (account_num, email) references authors
);

create table shipping
(
	order_num integer,
	user_id integer,
	order_date date,
	arrival_date date,
	primary key(order_num, user_id),
	foreign key(user_id) references users
);

create table users
(
	user_id serial,
	email varchar(30) not null,
	primary key (user_id),
	foreign key (email) references logins
);