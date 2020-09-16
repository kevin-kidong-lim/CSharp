 select id, [sale_year] as '년도',[sale_month] as '월',[pos_sales_amt] as '[POS] REVENUE(SALES)' ,[pos_lottery_amt] as '[POS] LOTTERY(POS)',
 [lottery_amt],[lottery_commition_amt],[sales_amt] from [dbo].sales 
 order by sale_year,sale_month  asc

 select sale_month, sum([pos_sales_amt]) as '2019', 0 as '2020'
 from  [dbo].sales
 where sale_year = '2019'
 group by sale_month
 union all
  select sale_month, 0 as '2019', sum([pos_sales_amt]) as '2020'
 from  [dbo].sales
 where sale_year = '2020'
 group by sale_month

   select sale_month
   , isnull( sum( case when sale_year = '2018' then [pos_sales_amt] end) , 0) as '2018'
   , isnull(sum( case when sale_year = '2019' then [pos_sales_amt] end) , 0) as '2019'
    ,isnull(sum( case when sale_year = '2020' then [pos_sales_amt] end) , 0) as '2020'
 from  [dbo].sales
 group by sale_month


 select sale_month, isnull( sum( case when sale_year = '2018' then [pos_sales_amt] end) , 0) as '2018'
 , isnull( sum( case when sale_year = '2018' then [pos_sales_amt] end) , 0) as '2018' 
 , isnull(sum( case when sale_year = '2019' then [pos_sales_amt] end) , 0) as '2019' 
  , isnull(sum( case when sale_year = '2020' then [pos_sales_amt] end) , 0) as '2020' 
 from  [dbo].sales  group by sale_month

 
select  convert(varchar(6),[regDate], 112) ,sum([total]) as total
,sum([gst]) as gst  ,delete_flag
from dbo.purchase where convert(varchar(6),[regDate], 112) between '201901' and '201912'
and category ='Purchase' 
group by convert(varchar(6),[regDate], 112) ,delete_flag
