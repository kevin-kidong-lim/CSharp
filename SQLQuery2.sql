--update purchase set payee ='Red Bull Canada' where payee='redbull canada' ;

select sum([total]) as total_sum ,sum([gst]) as gst_sum,sum([pst]) as pst_sum  from purchase
where  convert(varchar(6),[regDate], 112) between'2020' and '2020' 

select substring(convert(varchar(6),[regDate], 112), 5,2) ,* from [dbo].[purchase] 
where   convert(varchar(4),[regDate], 112) = '2019' 
-----------------------------------------------------
select (A.[2019_total]-A.[2019_gst]) as '2019 매입', B.[2019 sale] as '2019 매출'
  ,  (A.[2020_total]-A.[2020_gst]) as '2020 매입', B.[2020 sale] as '2020 매출' from (
select substring(convert(varchar(6),[regDate], 112), 5,2) as month 
 ,isnull(sum( case when  convert(varchar(4),[regDate], 112) = '2019' then [total] end) , 0) as '2019_total'
  ,isnull(sum( case when  convert(varchar(4),[regDate], 112) = '2019' then [gst] end) , 0) as '2019_gst'
   ,isnull(sum( case when  convert(varchar(4),[regDate], 112) = '2019' then pst end) , 0) as '2019_pst'
    ,isnull(sum( case when  convert(varchar(4),[regDate], 112) = '2020' then [total] end) , 0) as '2020_total'
  ,isnull(sum( case when  convert(varchar(4),[regDate], 112) = '2020' then [gst] end) , 0) as '2020_gst'
   ,isnull(sum( case when  convert(varchar(4),[regDate], 112) = '2020' then pst end) , 0) as '2020_pst'
from [dbo].[purchase] 
where   convert(varchar(4),[regDate], 112) > '2018' and delete_flag <> 'Y'
group by substring(convert(varchar(6),[regDate], 112), 5,2)
) A join (
select sale_month
 , isnull(sum( case when sale_year = '2019' then [sales_amt] end) , 0) as '2019 sale' 
 , isnull(sum( case when sale_year = '2020' then [sales_amt] end) , 0) as '2020 sale' 
 from  [dbo].sales  group by sale_month 
 ) B on A.month = B.sale_month
 -------------------------------------------------------
 select category, ( total_sum -gst_sum) as tt  from (
 select category, sum([total]) as total_sum ,sum([gst]) as gst_sum,sum([pst]) as pst_sum 
 from [dbo].[purchase] 
where   convert(varchar(6),[regDate], 112) = '201907' 
 and delete_flag <> 'Y'
 group by category
 ) A
