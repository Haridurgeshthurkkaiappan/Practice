--joins
create table orders
(
 orderid int not null,
 orderitem nvarchar(500) not null,
 locationname nvarchar (500) not null
 )
 select * from orders

 insert into orders values (101,'iphone','akkaripatti'),
 (102,'earpodes','palani'),
 (103,'tv','narikkalpatti')


 create table table2
(
coustemerid int not null,
 coustmername nvarchar (500) not null,
 coustmermembership nvarchar (500) not null,
 orderid int not null

 )
 select * from table2

 insert  into table2 values (201,'vasanth','prime',101),
 (202,'siva','gold',102),
 (203,'ajay','gold',103)

 select * from orders
 select * from table2

 select o.orderid,o.orderitem,t.coustmername from orders o inner join table2 t on
  o.orderid = t.orderid  where t.coustemerid in (201)-- where t.coustemerid between 201 and 203

  select o.orderid,o.orderitem,t.coustmername from orders o left outer join table2 t on
  o.orderid = t.orderid -- where t.coustemerid in (201)

  select o.orderid,o.orderitem,t.coustmername from orders o right outer join table2 t on
  o.orderid = t.orderid

  select o.orderid,o.orderitem,t.coustmername from orders o  full outer join table2 t on
  o.orderid = t.orderid


  --clause
  --order by

  select * from orders
  order by orderid desc

    select * from orders
  order by orderid asc

   select * from orders
  order by locationname asc

  --groupby

  select min (orderid),orderitem from orders
  where locationname='palani'
  group by orderitem 
  

