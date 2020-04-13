--This File contains all Trigger Functions used--

/*
This trigger function is used when owners
add new books to their collections. The
original book is added to the books collection,
then this trigger function will add it to a
collection for reports.
*/
create or replace function add_to_owner_books()
returns trigger as $$
begin
	insert into owner_book_reports
	select NEW.owner, NEW.title, NEW.book_id, 0, 0.0;
	return NEW;
end;
$$ language plpgsql;

/*
This trigger function is used
when an order is cancelled
*/
create or replace function remove_from_shipping()
returns trigger as $$
begin
	delete from shipping
	where user_id = OLD.user_id
	and order_num = OLD.order_num;
	return new;
end;
$$ language plpgsql;

/*
This function is triggered at checkout
and produces shipping information for the
order
*/
create or replace function shipping_trigger()
returns trigger as $$
begin
	insert into shipping (order_num, user_id, order_date, arrival_date)
	values(NEW.order_num, NEW.user_id, NEW.order_date, current_date + 7);	
	return new;
end;
$$language plpgsql;