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
 
 exec dbo.summary_year @param1 ='201901', @param2=1
 exec dbo.summary_year @param1 ='201902', @param2=1
 exec dbo.summary_year @param1 ='201903', @param2=1
 exec dbo.summary_year @param1 ='201904', @param2=1
 exec dbo.summary_year @param1 ='201905', @param2=1
 exec dbo.summary_year @param1 ='201906', @param2=1
 exec dbo.summary_year @param1 ='201907', @param2=1
 exec dbo.summary_year @param1 ='201908', @param2=1
 exec dbo.summary_year @param1 ='201909', @param2=1
 exec dbo.summary_year @param1 ='201910', @param2=1
 exec dbo.summary_year @param1 ='201911', @param2=1
 exec dbo.summary_year @param1 ='201912', @param2=1

 exec dbo.summary_year @param1 ='201901', @param2=2
 exec dbo.summary_year @param1 ='201902', @param2=2
 exec dbo.summary_year @param1 ='201903', @param2=2
 exec dbo.summary_year @param1 ='201904', @param2=2
 exec dbo.summary_year @param1 ='201905', @param2=2
 exec dbo.summary_year @param1 ='201906', @param2=2
 exec dbo.summary_year @param1 ='201907', @param2=2
 exec dbo.summary_year @param1 ='201908', @param2=2
 exec dbo.summary_year @param1 ='201909', @param2=2
 exec dbo.summary_year @param1 ='201910', @param2=2
 exec dbo.summary_year @param1 ='201911', @param2=2
 exec dbo.summary_year @param1 ='201912', @param2=2


 exec dbo.summary_year @param1 ='202001', @param2=1
 exec dbo.summary_year @param1 ='202002', @param2=1
 exec dbo.summary_year @param1 ='202003', @param2=1
 exec dbo.summary_year @param1 ='202004', @param2=1
 exec dbo.summary_year @param1 ='202005', @param2=1
 exec dbo.summary_year @param1 ='202006', @param2=1
 exec dbo.summary_year @param1 ='202007', @param2=1
 exec dbo.summary_year @param1 ='202008', @param2=1
 exec dbo.summary_year @param1 ='202009', @param2=1
 exec dbo.summary_year @param1 ='202010', @param2=1
 exec dbo.summary_year @param1 ='202011', @param2=1
 exec dbo.summary_year @param1 ='202012', @param2=1

 exec dbo.summary_year @param1 ='202001', @param2=2
 exec dbo.summary_year @param1 ='202002', @param2=2
 exec dbo.summary_year @param1 ='202003', @param2=2
 exec dbo.summary_year @param1 ='202004', @param2=2
 exec dbo.summary_year @param1 ='202005', @param2=2
 exec dbo.summary_year @param1 ='202006', @param2=2
 exec dbo.summary_year @param1 ='202007', @param2=2
 exec dbo.summary_year @param1 ='202008', @param2=2
 exec dbo.summary_year @param1 ='202009', @param2=2
 exec dbo.summary_year @param1 ='202010', @param2=2
 exec dbo.summary_year @param1 ='202011', @param2=2
 exec dbo.summary_year @param1 ='202012', @param2=2


 select * from summary_year_tb


  select category, ( total_sum -gst_sum) as tt  from (
 select category, sum([total]) as total_sum ,sum([gst]) as gst_sum,sum([pst]) as pst_sum 
 from [dbo].[purchase] 
where   convert(varchar(6),[regDate], 112) = '201907' 
 and delete_flag <> 'Y'
 group by category
 ) A

 --------------------------------------------------------------
 insert into summary_year_tb (sale_yyyymm, income, category, [total_amt])
   select yyyymm,0,category, ( total_sum -gst_sum) as tt 
   from (
 select  '201901' as yyyymm, category, sum([total]) as total_sum ,sum([gst]) as gst_sum,sum([pst]) as pst_sum 
 from [dbo].[purchase] 
where   convert(varchar(6),[regDate], 112) = '201901' 
 and delete_flag <> 'Y'
 group by category
 ) A
  --------------------------------------------------------------
  insert into summary_year_tb (sale_yyyymm, income, category, [total_amt])
  select sale_year+sale_month, 0,'Sales' as category, sales_amt
  from sales
  where sale_year ='2019' and sale_month='12'
  union 
  select sale_year+sale_month, 0,'Lotto Sales' as category, pos_lottery_amt
  from sales
  where sale_year ='2019' and sale_month='12'
   union 
  select sale_year+sale_month, 0,'Lotto Purchase' as category, round(pos_lottery_amt*0.9088,2)
  from sales
  where sale_year ='2019' and sale_month='12';

    select *
  from sales
  where sale_year ='2019' and sale_month='12';

  delete from summary_year_tb where sale_yyyymm = '201912' and income in (3000,3050,4001); 

 ---------------------------
 -- 20194월 웨스턴유니온은 구매로 잡아야 할듯, 매출은 pos에서 잡았으니, 기프트카드 처럼.
 -- 2019 8월 post 는 경비로 처리.. 
  update  summary_year_tb set income_group='Expense',income = 4440,  category = 'Office and General' where category = 'post';
  update  summary_year_tb set income_group='Cost of Goods Sold',income = 4000, category = 'Purchase'  where category = 'western union';
   update  summary_year_tb set income_group='Cost of Goods Sold',income = 4000, category = 'Purchase'  where category = 'Purchase';
 update  summary_year_tb set income_group='Income',income = 3000 where category = 'Sales';
 update  summary_year_tb set income_group='Income',income = 3050 where category = 'Lotto Sales';
 update  summary_year_tb set income_group='Cost of Goods Sold',income = 4001 where category = 'Lotto Purchase';
 update  summary_year_tb set income_group='Cost of Goods Sold',income = 4000 where category = 'Purchase';
 update  summary_year_tb set income_group='Expense',income = 4151 where category = 'Automobile - Gas';
 update  summary_year_tb set income_group='Expense',income = 4301 where category = 'Bank Charges';
 update  summary_year_tb set income_group='Expense',income = 4580 where category = 'franchise fee';
 update  summary_year_tb set income_group='Expense',income = 4460 where category = 'Professional Fee';
 update  summary_year_tb set income_group='Expense',income = 6000 where category = 'PST Paid to Government';
 update  summary_year_tb set income_group='Expense',income = 4500 where category = 'rent';
 update  summary_year_tb set income_group='Expense',income = 4850 where category = 'Telephone and Utilities';
 update  summary_year_tb set income_group='Expense',income = 4440 where category = 'Office and General';
 update  summary_year_tb set income_group='Expense',income = 4200 where category = 'BUSINESS INSURANCE';
 update  summary_year_tb set income_group='Expense',income = 4170 where category = 'business tax';
 update  summary_year_tb set income_group='Expense',income = 4152 where category = 'Automobile - Parking';
 update  summary_year_tb set income_group='Expense',income = 4154 where category = 'Automobile - Insurance';
 update  summary_year_tb set income_group='Expense',income = 4420 where category = 'Meals and Entertainment';
 update  summary_year_tb set income_group='Expense',income = 4581 where category = 'pos';
 update  summary_year_tb set income_group='Expense',income = 4441 where category = 'promo materials(jan,feb)';
 update  summary_year_tb set income_group='Expense',income = 4442 where category = 'FEB';

 select * from summary_year_tb

 select * from [dbo].[purchase] where category = 'automobile- gas' or category ='automobile-gas'
 update [dbo].[purchase] set  category = 'Automobile - Gas'  where category = 'automobile- gas' or category ='automobile-gas'
 Automobile - Gas

 CREATE TABLE [dbo].[summary_year_tb] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [sale_yyyymm]   NVARCHAR (6)    NOT NULL,
    [income]      INT             NOT NULL,
    [category]    NVARCHAR (50)   NOT NULL,
    [total_amt]   NUMERIC (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


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


-- rollup

select [sale_yyyymm], income, category
     , substring([sale_yyyymm], 5,2)
    from [summary_year_tb]

Advertising	광고비	
Automobile - Gas	자동차 개스	자동차 경비는 비즈니스용
Automobile - Insurance	자동차 보험료	으로 쓰는 차만 됩니다.
Automobile - Repair	자동차 수리비	
Automobile - License	자동차 등록비	
Automobile - Lease or Financing	자동차 리스 및 파이낸싱	
Automobile - Parking	자동차 주차비	
Bank Charges	은행 수수료, 카드 수수료 등	
Business Tax, License	비즈니스 tax, 시청 등에 낸 라이센스 경비	
Equipment	컴퓨터, 금전 등록기, 선반 등 장비 구입	
Insurance	비즈니스 보험, 종업원 상해보험(WSB)	
Interest	이자 경비	
Leasehold	초기 공사 및 시설비 	
Meals and Entertainment	비즈니스 목적을 위한 식사 비용	
Office and General	일반 사무 용품이나 기타 경비	
Purchase	판매용 물품 또는 식재료 등 원재료 구입	
Professional Fee	회계비, 변호사비	
Rent	렌트	
Repair and Maintenance	수리 및 유지비	
Salaries	월급	
Payroll Remittance 	매달 정부에 보내는 월급 원천공제한 것	
Property Tax	재산세	
Supplies	가게에 필요한 제반 소모품	
Telephone and Utilities	전화, 전기세 등	
PST Paid to Government	PST 정부에 낸 금액	
GST Paid to Government	GST 정부에 낸 금액	
