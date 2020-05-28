select  [regDate],convert(varchar(6),[regDate], 112) aa ,[payMethod],[checkNo],[payee],[total],[gst],[category],[etc] ,[createDate]  from purchase
where convert(varchar(6),[regDate], 112)  between '201904' and '201904'



select [regDate],[payMethod],[checkNo],[payee],[total],[gst],[category],[etc] ,[createDate] from [dbo].[purchase]
where  convert(varchar(6),[regDate], 112) between '201912' and '201912'union all

select  '' as [regDate]  , '' as [payMethod], '' as [checkNo] ,'' as [payee],sum([total]) as total
,sum([gst]) as gst ,'' as [category],'' as [etc] , '' as [createDate]  from purchase where convert(varchar(6),[regDate], 112) between '201912' and '201912'


-- delete from [dbo].[invoices];
-- select * from  [dbo].[invoices];
select invoice_date, item_name, class_code 
from  [dbo].[invoices]
group by  invoice_date, item_name, class_code 

select  item_name, class_code ,count(*)
from  [dbo].[invoices]
group by   item_name, class_code
order by class_code asc

select item_name,sum(item_price) as sum
from  [dbo].[invoices] 
where item_name like 'coke%'
group by item_name

select sum(total_order) total_order
from(
select invoice_date,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_
from  [dbo].[invoices]
group by  invoice_date
--order by invoice_date asc
) A


select invoice_date,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_
from  [dbo].[invoices]
group by  invoice_date
order by invoice_date asc

-- item 그룹으로  MY BLU, JUUL
select  item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_qty) order_qty,sum(order_total) order_total2
,sum(( item_gst*order_qty)) order_gst
from  [dbo].[invoices] where 1=1
--and class_code <> 1
and item_name like '%JUUL%' or item_name like '%MY BLU%' 
group by  item_name, class_code 
order by item_name asc

-- 날짜, item 그룹
select   invoice_date, item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_order2,sum(order_qty) order_qty,sum(item_price) item_price,sum(item_gst*order_qty) item_gst
from  [dbo].[invoices] where 1=1
--and class_code <> 1
and item_name like '%JUUL%' or item_name like '%MY BLU%' 
group by  invoice_date, item_name, class_code 
order by item_name asc

-- item 그룹으로  담배, 전자담배 제외
select  item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_order2,sum(order_qty) order_qty,sum(item_price) item_price,sum(item_gst*order_qty) item_gst
from  [dbo].[invoices] where 1=1
and class_code = 1
and item_name not like '%JUUL%' and item_name not like '%MY BLU%'
and  item_name like '%BELMONT%'
group by  item_name, class_code 

select  item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_qty) order_qty,sum(order_total) order_total2
,sum(( item_gst*order_qty)) order_gst
from  [dbo].[invoices] where 1=1
and class_code = 1
and item_name not like '%JUUL%' and item_name not like '%MY BLU%'
group by  item_name, class_code 
order by item_name asc

-- 날짜, item 그룹
select   invoice_date, item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_order2,sum(order_qty) order_qty,sum(item_price) item_price,sum(item_gst*order_qty) item_gst
from  [dbo].[invoices] where 1=1
and class_code = 1
and item_name not like '%JUUL%' and item_name not like '%MY BLU%'
group by  invoice_date, item_name, class_code 

select * 
from  [dbo].[invoices] where 1=1
and class_code = 1
and item_name not like '%JUUL%' and item_name not like '%MY BLU%'
and  item_name like '%BELMONT%'


update   [dbo].[invoices] set supplier ='wallas'; 


update   [dbo].[invoices] set supplier ='RedBull' where supplier is null;

select * from  [dbo].[invoices]

where supplier ='imperial' 

update   [dbo].[invoices] set item_gst = item_price * 0.05  where supplier ='imperial';



select  item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_qty) order_qty,sum(order_qty)*24 as qty_total
,sum(order_total) order_total2
,sum(( item_gst*order_qty)) order_gst
from  [dbo].[invoices] where 1=1
and supplier ='redbull'
group by  item_name, class_code 
order by item_name asc

-- 날짜, item 그룹
select   invoice_date, item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_order2,sum(order_qty) order_qty,sum(order_qty)*24 as qty_total
,sum(item_price) item_price,sum(item_gst*order_qty) item_gst
from  [dbo].[invoices] where 1=1
and supplier ='redbull'
group by  invoice_date, item_name, class_code 
