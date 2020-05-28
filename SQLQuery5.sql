-- item 그룹으로  MY BLU, JUUL
select  item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_qty) order_qty,sum(order_total) order_total2
,sum(( item_gst*order_qty)) order_gst
from  [dbo].[invoices] where 1=1
--and class_code <> 1
and item_name like '%JUUL%' or item_name like '%MY BLU%' 
group by  item_name, class_code 
order by item_name asc

select   invoice_date, item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_total) total_order2,sum(order_qty) order_qty,sum(item_price) item_price,sum(item_gst*order_qty) item_gst
from  [dbo].[invoices] where 1=1
--and class_code <> 1
and item_name like '%JUUL%' or item_name like '%MY BLU%' 
group by  invoice_date, item_name, class_code 
order by item_name asc


select  item_name, class_code ,sum(order_total+( item_gst*order_qty)) total_order,sum(order_qty) order_qty,sum(order_qty)*24 as qty_total
,sum(order_total) order_total2
,sum(( item_gst*order_qty)) order_gst
from  [dbo].[invoices] where 1=1
and supplier ='rbh'
group by  item_name, class_code 
order by item_name asc