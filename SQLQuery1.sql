select * from common_code where p_code=1 and name like 'bianca%';

select * from common_code where p_code=2

select * from [dbo].[purchase] where regdate >= '20200601' and  regdate < '20200701';

select sum(gst) as gst from [dbo].[purchase] where regdate >= '20200101' and  regdate < '20200201';

insert into common_code (p_code,c_code,name,hidden_store) values ('1',195,'bianca armors','Y');


delete from purchase where regdate >= '20200601' and  regdate < '20200701';
delete from purchase where id in (1385,1386)

select * from [dbo].[purchase] where payee = 'visualtouch'

select payee from purchase
group by payee
order by payee


select category from purchase
group by category
order by category
select * from [dbo].[purchase] where category = 'pos'
insert into common_code (p_code,c_code,name,hidden_store) values ('2',232,'promo materials','Y');