create procedure sil
@id int
as
begin
delete from tbl_HastaBilgi where ID = @id
end
