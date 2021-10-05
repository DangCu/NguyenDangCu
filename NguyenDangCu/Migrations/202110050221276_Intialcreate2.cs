namespace NguyenDangCu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intialcreate2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SinhVien");
            AlterColumn("dbo.LopHoc", "TenLop", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SinhVien", "MaSinhVien", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.SinhVien", "HoTen", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.SinhVien", "MaSinhVien");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SinhVien");
            AlterColumn("dbo.SinhVien", "HoTen", c => c.String());
            AlterColumn("dbo.SinhVien", "MaSinhVien", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.LopHoc", "TenLop", c => c.String());
            AddPrimaryKey("dbo.SinhVien", "MaSinhVien");
        }
    }
}
