-- SQL functions for bookstore application --

/*
The following function is used primarily
during the signup process and it handles
the logic behind determining owners vs
regular users

E.G. add_user('aaron@live.ca', '123123', false)
*/
create or replace function add_user(varchar(30), varchar(30), boolean)
returns void as $$
declare
	emailF alias for $1;
	pword alias for $2;
	owner alias for $3;
begin
	insert into logins (email, password, store_owner)
	values (emailF, pword, owner);
	insert into users(user_id, email)
	values (default, emailF);
end;
$$ language plpgsql;

/*
The following function is used to produce
ID values. As it returns a varying length string
we can use it for any length of id. In this application
it was used to produce IDs for books.

E.G. random_string(4) -> 1A1A
*/
create or replace function random_string(length integer) returns text as $$
declare
  chars text[] := '{0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z}';
  result text := '';
  i integer := 0;
begin
  if length < 0 then
    raise exception 'Given length cannot be less than 0';
  end if;
  for i in 1..length loop
    result := result || chars[1+random()*(array_length(chars, 1)-1)];
  end loop;
  return result;
end;
$$ language plpgsql;

/*
The following function is used during the
checkout process. Once checkout is confirmed
all books are remove from the cart.

E.G. remove_from_cart(1, 1A1A)
*/
create or replace function remove_from_cart(integer, varchar(30))
returns void as $$
declare
	userID alias for $1;
	bookID alias for $2;
begin
	delete from books_in_cart
	where user_id = userID
	and book_id = bookID;
end;
$$ language plpgsql;

/*
The following function was used during the checkout
process. Depending on the book split_pay will
pay both the author and the owner their shares
after a user purchases their books.

E.G. split_pay('King James Bible')
*/
create or replace function split_pay(varchar(30))
returns void as $$
declare
	b_title alias for $1;
	price numeric(5,2) := (select price from books where title = b_title);
	author_name varchar(30) := (select author from books where title = b_title);
	cut float := (select royalties from authors where name = author_name);
	admin varchar(30) := (select owner from books where title = b_title);
begin
	update authors
	set account_balance = account_balance + (price * (cut/100.0))
	where name = author_name;
	update owner
	set balance = balance + (price * ((100 - cut)/100.0))
	where email = admin;
end;
$$ language plpgsql;

/*
This function updates the owners reports.
This includes both incrementing the copies_sold
counters, and the revenue.

E.G. update_reports('King James Bible')
*/
create or replace function update_reports(varchar(30))
returns void as $$
declare
	b_title alias for $1;
	b_owner varchar(120) := (select owner from books where title = b_title);
	b_price float := (select price from books where title = b_title);
	owner_cut float := 100 - (select royalties from authors where name = (select author from books where title = b_title));
begin
	-- update copies sold --
	update owner_book_reports
	set copies_sold = copies_sold + 1
	where title = b_title and owner = b_owner;
	
	-- update money made -- 
	update owner_book_reports
	set money_made = money_made + (b_price * (owner_cut / 100))
	where title = b_title and owner = b_owner;
end;
$$ language plpgsql;
