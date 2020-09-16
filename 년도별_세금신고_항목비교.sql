select  income_group,income, category
    , isnull( sum( case substring([sale_yyyymm], 5,2) when '01' then([total_amt]) end), 0) [1월]
    , isnull( sum( case substring([sale_yyyymm], 5,2) when '02' then [total_amt] end), 0) [2월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '03' then [total_amt] end), 0) [3월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '04' then [total_amt] end), 0) [4월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '05' then [total_amt] end), 0) [5월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '06' then [total_amt] end), 0) [6월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '07' then [total_amt] end), 0) [7월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '08' then [total_amt] end), 0) [8월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '09' then [total_amt] end), 0) [9월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '10' then [total_amt] end), 0) [10월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '11' then [total_amt] end), 0) [11월]
    , isnull(sum( case substring([sale_yyyymm], 5,2) when '12' then [total_amt] end), 0) [12월]
    , isnull(sum([total_amt]), 0) [Total]
from [summary_year_tb]
where substring([sale_yyyymm], 1,4) ='2020'
group by  income_group,income, category
order by income asc 


   sql = " select sale_month"
                 + " , isnull( sum( case when sale_year = '2018' then [sales_amt] end) , 0) as '2018' "
                 + " , isnull(sum( case when sale_year = '2019' then [sales_amt] end) , 0) as '2019' "
                  + " , isnull(sum( case when sale_year = '2020' then [sales_amt] end) , 0) as '2020' "
                  + " from  [dbo].sales  group by sale_month ";


select substring(sale_yyyymm, 5,2), income_group, category
, sum(total_amt) total_amt
, isnull( sum( case  substring(sale_yyyymm, 1,4) when '2019' then total_amt end) , 0) as '2019'
, isnull( sum( case  substring(sale_yyyymm, 1,4) when '2020' then total_amt end) , 0) as '2020'
from [summary_year_tb]
where income not in (4152,3205)
group by substring(sale_yyyymm, 5,2), income_group, category,income
order by substring(sale_yyyymm, 5,2), income asc

select *  
from [summary_year_tb]
where income not in (4152,6000)


select isnull(month,'YY'), isnull(income_group,'Total'), [2019], [2020], ([2020] - [2019]) as Bido
from (
select  substring(sale_yyyymm, 5,2) month,income_group
, isnull( sum( case  substring(sale_yyyymm, 1,4) when '2019' then case income_group  when 'income' then total_amt else -total_amt end end) , 0) as '2019'
, isnull( sum( case  substring(sale_yyyymm, 1,4) when '2020' then case income_group  when 'income' then total_amt else -total_amt end end) , 0) as '2020'
from [summary_year_tb]
where income not in (4152,6000)
group by  substring(sale_yyyymm, 5,2),income_group
with rollup
--order by  substring(sale_yyyymm, 5,2),income_group desc
) A
order by month,income_group desc
