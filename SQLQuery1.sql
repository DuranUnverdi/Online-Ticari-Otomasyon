CREATE Trigger SatisStokAzalt
On SatisHarekets
After insert
as
Declare @UrunID int
Declare @Adet int
Select @UrunID=Urunid,@Adet=Adet from inserted
Update Uruns set Stok=Stok-@Adet where UrunID=@UrunID