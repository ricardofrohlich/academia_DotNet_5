
create table java
(
	professor varchar(50) null
)

create table net
(
	professor varchar(50) null
)

insert into java values ('Fabrício'), ('Gabriel'), ('Luan')

insert into net values ('Fabrício'), ('Ricardo'), ('Alexandre')


--inner join
select * from java 
inner join net on java.professor = net.professor

-- left join
select * from java
left join net on java.professor = net.professor


-- left join exclusivo
select * from java
left join net on java.professor = net.professor
where net.professor is null

-- right join
select java.professor as Java, net.professor as Net from java 
right join net on java.professor = net.professor

-- right join exclusivo
select * from java
right join net on java.professor = net.professor
where java.professor is null

-- outer join
select * from java
full outer join net on java.professor = net.professor

-- outer join exclusivo
select * from java
full outer join net on java.professor = net.professor
where java.professor is null or net.professor is null

