--delete from purchase where regdate >= '20190801';
-- select * from [dbo].[purchase] where regdate >= '20190901';
-- select * from purchase where payee = 'Frito Lay Canada'
--select distinct payee from purchase;

ALTER TABLE dbo.purchase ADD pst INT  NULL;

select * from [dbo].[purchase] where regdate >= '20191001' and id =1045

update  [dbo].[purchase] set pst =7.88 where regdate >= '20191001' and id =1045

ALTER TABLE dbo.purchase ADD pst INT  NULL;
ALTER TABLE dbo.purchase ALTER COLUMN pst NUMERIC (18, 2);  


select  convert(varchar(6),[regDate], 112) ,sum([total]) as total
,sum([gst]) as gst  ,delete_flag
from purchase where convert(varchar(6),[regDate], 112) between '201901' and '201912'
and category ='Purchase' 
group by convert(varchar(6),[regDate], 112) ,delete_flag

update purchase set payee ='Best Buy' where payee='Best Buy' ;
update purchase set payee ='BOUCLAIR' where payee='BOUCLAIR' ;
update purchase set payee ='Brian Min' where payee='Brian Min' ;
update purchase set payee ='Canada post' where payee='canada post' ;
update purchase set payee ='CANADIAN TIRE' where payee='CANADIAN TIRE' ;
update purchase set payee ='chase paymenttech' where payee='chase paymenttech' ;
update purchase set payee ='City of Winnipeg' where payee='city of winnipeg' ;
update purchase set payee ='Co-op' where payee='co-op' ;
update purchase set payee ='CostCo' where payee='costco' ;
update purchase set payee ='Dakin news' where payee='dakin news' ;
update purchase set payee ='debit' where payee='debit' ;
update purchase set payee ='debit' where payee='debit charge' ;
update purchase set payee ='Dollar  Tree Stores' where payee='Dollar  Tree Stores' ;
update purchase set payee ='Dollar  Tree Stores' where payee='Dollar Tree' ;
update purchase set payee ='Dollar  Tree Stores' where payee='Dollar Tree Stores' ;
update purchase set payee ='Dollarama' where payee='Dollarama' ;
update purchase set payee ='Dollarama' where payee='dollarma' ;
update purchase set payee ='Dollarama' where payee='DOLLARMAM' ;
update purchase set payee ='Dollar  Tree Stores' where payee='dollartree' ;
update purchase set payee ='Frito Lay Canada' where payee='Frito lay' ;
update purchase set payee ='Frito Lay Canada' where payee='Frito Lay Canada' ;
update purchase set payee ='Harvard ' where payee='Harvard ' ;
update purchase set payee ='Honda Service' where payee='Honda Service' ;
update purchase set payee ='Hub interational' where payee='hub interational' ;
update purchase set payee ='IKEA' where payee='IKEA' ;
update purchase set payee ='Impark' where payee='Impark' ;
update purchase set payee ='Imperial Tobacco' where payee='Imperial Tobacco' ;
update purchase set payee ='Imperial Tobacco' where payee='imperial' ;
update purchase set payee ='incomm canada llc' where payee='incomm canada llc' ;
update purchase set payee ='Indigo' where payee='Indigo' ;
update purchase set payee ='Dakin news' where payee='INS' ;
update purchase set payee ='Lee myong law cor' where payee='lee myong law cor' ;
update purchase set payee ='Manitoba PST' where payee='Manitoba PST' ;
update purchase set payee ='Manitoba PST' where payee='manitoba sales tax' ;
update purchase set payee ='Nestle canada' where payee='nestle canada' ;
update purchase set payee ='PeTRO-CANADA' where payee='PeTRO-CANADA' ;
update purchase set payee ='RBH' where payee='RBH' ;
update purchase set payee ='Red Bull Canada' where payee='red bull canada' ;
update purchase set payee ='Red lobster' where payee='red lobster' ;
update purchase set payee ='Roges' where payee='ROGERS' ;
update purchase set payee ='Roges' where payee='Roges' ;
update purchase set payee ='scotia bank' where payee='scotia bank' ;
update purchase set payee ='Shaw' where payee='shaw' ;
update purchase set payee ='Shaw' where payee='shaw cable' ;
update purchase set payee ='Shoppers' where payee='shoppers' ;
update purchase set payee ='SRP Companies' where payee='SRP Companies' ;
update purchase set payee ='Superstore' where payee='superstore' ;
update purchase set payee ='Sushi One' where payee='Sushi One' ;
update purchase set payee ='Dollar  Tree Stores' where payee='Tollar Tree' ;
update purchase set payee ='Wallace&Carey' where payee='Wallace&Carey' ;
update purchase set payee ='Walmart' where payee='walmart' ;
update purchase set payee ='Wholesale club' where payee='wholesale' ;
update purchase set payee ='Wholesale club' where payee='wholesaleclub' ;
update purchase set payee ='Wholesale club' where payee='Wholesale club' ;
update purchase set payee ='Wholesale club' where payee='Wholesale clube' ;
update purchase set payee ='Wholesale club' where payee='Wholesale clubr' ;
update purchase set payee ='Winnipeg Parking Authority' where payee='Winnipeg Parking Authority' ;
update purchase set payee ='Winnipeg Transit ' where payee='Winnipeg Transit' ;
update purchase set payee ='Western union ' where payee='wufs' ;
update purchase set payee ='Western union ' where payee='wusf' ;
