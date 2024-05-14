using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrjSelectShopbackV1.Models;

public partial class SelectShopContext : DbContext
{
    public SelectShopContext()
    {
    }

    public SelectShopContext(DbContextOptions<SelectShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bag> Bags { get; set; }

    public virtual DbSet<Box> Boxes { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<GiftPackageStyle> GiftPackageStyles { get; set; }

    public virtual DbSet<MaterialColor> MaterialColors { get; set; }

    public virtual DbSet<PackageMaterial> PackageMaterials { get; set; }

    public virtual DbSet<ProductTop1Sale> ProductTop1Sales { get; set; }

    public virtual DbSet<ProductTop4Sale> ProductTop4Sales { get; set; }

    public virtual DbSet<ProductTotalSale> ProductTotalSales { get; set; }

    public virtual DbSet<TActive> TActives { get; set; }

    public virtual DbSet<TAgency> TAgencies { get; set; }

    public virtual DbSet<TAllPackage> TAllPackages { get; set; }

    public virtual DbSet<TAppraisal> TAppraisals { get; set; }

    public virtual DbSet<TCart> TCarts { get; set; }

    public virtual DbSet<TCategory> TCategories { get; set; }

    public virtual DbSet<TCity> TCities { get; set; }

    public virtual DbSet<TCollect> TCollects { get; set; }

    public virtual DbSet<TDepartment> TDepartments { get; set; }

    public virtual DbSet<TDistributor> TDistributors { get; set; }

    public virtual DbSet<TDistrict> TDistricts { get; set; }

    public virtual DbSet<TEmployee> TEmployees { get; set; }

    public virtual DbSet<TEnterprise> TEnterprises { get; set; }

    public virtual DbSet<TEventLog> TEventLogs { get; set; }

    public virtual DbSet<TKeyword> TKeywords { get; set; }

    public virtual DbSet<TLabel> TLabels { get; set; }

    public virtual DbSet<TMember> TMembers { get; set; }

    public virtual DbSet<TOrder> TOrders { get; set; }

    public virtual DbSet<TOrderTemp> TOrderTemps { get; set; }

    public virtual DbSet<TPackageWayDetail> TPackageWayDetails { get; set; }

    public virtual DbSet<TPay> TPays { get; set; }

    public virtual DbSet<TPayType> TPayTypes { get; set; }

    public virtual DbSet<TProdAppearance> TProdAppearances { get; set; }

    public virtual DbSet<TProduct> TProducts { get; set; }

    public virtual DbSet<TPurchase> TPurchases { get; set; }

    public virtual DbSet<TReview> TReviews { get; set; }

    public virtual DbSet<TSale> TSales { get; set; }

    public virtual DbSet<TStatus> TStatuses { get; set; }

    public virtual DbSet<TSubCategory> TSubCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SelectShop;Integrated Security=True;Trust Server Certificate=True\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bag>(entity =>
        {
            entity.Property(e => e.BagId).HasColumnName("BagID");
            entity.Property(e => e.BagType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PstlyeId).HasColumnName("PStlyeID");
            entity.Property(e => e.Size).HasMaxLength(200);
            entity.Property(e => e.SuitableProductsId).HasColumnName("SuitableProductsID");

            entity.HasOne(d => d.Material).WithMany(p => p.Bags)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_Bags_packageMaterial1");

            entity.HasOne(d => d.Pstlye).WithMany(p => p.Bags)
                .HasForeignKey(d => d.PstlyeId)
                .HasConstraintName("FK_Bags_GiftPackageStyle1");
        });

        modelBuilder.Entity<Box>(entity =>
        {
            entity.Property(e => e.BoxId).HasColumnName("BoxID");
            entity.Property(e => e.BoxType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PstlyeId).HasColumnName("PStlyeID");
            entity.Property(e => e.Size).HasMaxLength(200);
            entity.Property(e => e.SuitableProductsId).HasColumnName("SuitableProductsID");

            entity.HasOne(d => d.Material).WithMany(p => p.Boxes)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_Boxes_packageMaterial1");

            entity.HasOne(d => d.Pstlye).WithMany(p => p.Boxes)
                .HasForeignKey(d => d.PstlyeId)
                .HasConstraintName("FK_Boxes_GiftPackageStyle1");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.Property(e => e.CardId).HasColumnName("CardID");
            entity.Property(e => e.CardType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PstlyeId).HasColumnName("PStlyeID");
            entity.Property(e => e.SuitableProductsId).HasColumnName("SuitableProductsID");

            entity.HasOne(d => d.Pstlye).WithMany(p => p.Cards)
                .HasForeignKey(d => d.PstlyeId)
                .HasConstraintName("FK_Cards_GiftPackageStyle1");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(50);
        });

        modelBuilder.Entity<GiftPackageStyle>(entity =>
        {
            entity.HasKey(e => e.PstlyeId);

            entity.ToTable("GiftPackageStyle");

            entity.Property(e => e.PstlyeId).HasColumnName("PStlyeID");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Picture).IsUnicode(false);
            entity.Property(e => e.StyleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MaterialColor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("MaterialColor");

            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Rgb)
                .HasMaxLength(50)
                .HasColumnName("RGB");
        });

        modelBuilder.Entity<PackageMaterial>(entity =>
        {
            entity.HasKey(e => e.MaterialId);

            entity.ToTable("packageMaterial");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.Description).HasMaxLength(20);
            entity.Property(e => e.MaterialName).HasMaxLength(50);

            entity.HasOne(d => d.Color).WithMany(p => p.PackageMaterials)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_packageMaterial_MaterialColor");
        });

        modelBuilder.Entity<ProductTop1Sale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PRODUCT_TOP1_SALES");

            entity.Property(e => e.GrossProfit).HasColumnType("money");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(200);
        });

        modelBuilder.Entity<ProductTop4Sale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PRODUCT_TOP4_SALES");

            entity.Property(e => e.GrossProfit).HasColumnType("money");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(200);
        });

        modelBuilder.Entity<ProductTotalSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PRODUCT_TOTAL_SALES");

            entity.Property(e => e.GrossProfit).HasColumnType("money");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.SalesAverage).HasColumnType("money");
            entity.Property(e => e.TotalSales)
                .HasColumnType("money")
                .HasColumnName("Total_Sales");
            entity.Property(e => e.TotalSalesVolume).HasColumnName("Total_SalesVolume");
        });

        modelBuilder.Entity<TActive>(entity =>
        {
            entity.HasKey(e => e.ActiveId);

            entity.ToTable("tActive");

            entity.Property(e => e.ActiveId).HasColumnName("ActiveID");
            entity.Property(e => e.ActiveName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Discount).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TAgency>(entity =>
        {
            entity.HasKey(e => e.AgencyId);

            entity.ToTable("tAgency");

            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.AgencyName).HasMaxLength(50);
            entity.Property(e => e.EnterpriseId).HasColumnName("EnterpriseID");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.HasOne(d => d.Enterprise).WithMany(p => p.TAgencies)
                .HasForeignKey(d => d.EnterpriseId)
                .HasConstraintName("FK_tAgency_tEnterprise");
        });

        modelBuilder.Entity<TAllPackage>(entity =>
        {
            entity.HasKey(e => e.PackageId);

            entity.ToTable("tAllPackage");

            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.PackName).HasMaxLength(50);
            entity.Property(e => e.PackageStyleId).HasColumnName("PackageStyleID");
            entity.Property(e => e.Picture).IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");

            entity.HasOne(d => d.Material).WithMany(p => p.TAllPackages)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_tAllPackage_packageMaterial");

            entity.HasOne(d => d.PackageStyle).WithMany(p => p.TAllPackages)
                .HasForeignKey(d => d.PackageStyleId)
                .HasConstraintName("FK_tAllPackage_GiftPackageStyle1");
        });

        modelBuilder.Entity<TAppraisal>(entity =>
        {
            entity.HasKey(e => e.RankId);

            entity.ToTable("tAppraisal");

            entity.Property(e => e.RankId).HasColumnName("RankID");
            entity.Property(e => e.Rank).HasMaxLength(50);
        });

        modelBuilder.Entity<TCart>(entity =>
        {
            entity.HasKey(e => e.CartId);

            entity.ToTable("tCart");

            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Member).WithMany(p => p.TCarts)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_tCart_tMember");

            entity.HasOne(d => d.Product).WithMany(p => p.TCarts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tCart_tProduct");
        });

        modelBuilder.Entity<TCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("tCategory");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryCname)
                .HasMaxLength(200)
                .HasColumnName("CategoryCName");
            entity.Property(e => e.CategoryName).HasMaxLength(200);
        });

        modelBuilder.Entity<TCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tCity");

            entity.Property(e => e.CityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(50);
        });

        modelBuilder.Entity<TCollect>(entity =>
        {
            entity.HasKey(e => e.CollectId);

            entity.ToTable("tCollect");

            entity.Property(e => e.CollectId).HasColumnName("CollectID");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Member).WithMany(p => p.TCollects)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_tCollect_tMember");

            entity.HasOne(d => d.Product).WithMany(p => p.TCollects)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tCollect_tProduct");
        });

        modelBuilder.Entity<TDepartment>(entity =>
        {
            entity.HasKey(e => e.DepId).HasName("PK_Department");

            entity.ToTable("tDepartment");

            entity.Property(e => e.DepId).HasColumnName("DepID");
            entity.Property(e => e.DepName).HasMaxLength(50);
        });

        modelBuilder.Entity<TDistributor>(entity =>
        {
            entity.HasKey(e => e.DistributorId);

            entity.ToTable("tDistributor");

            entity.Property(e => e.DistributorId).HasColumnName("DistributorID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.DistributorName).HasMaxLength(50);
            entity.Property(e => e.EnterpriseId).HasColumnName("EnterpriseID");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.HasOne(d => d.Enterprise).WithMany(p => p.TDistributors)
                .HasForeignKey(d => d.EnterpriseId)
                .HasConstraintName("FK_tDistributor_tEnterprise");
        });

        modelBuilder.Entity<TDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("tDistrict");

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.DistrictNamt).HasMaxLength(50);

            entity.HasOne(d => d.City).WithMany(p => p.TDistricts)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_tDistrict_City");
        });

        modelBuilder.Entity<TEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("tEmployee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Birthday).HasMaxLength(50);
            entity.Property(e => e.Cellphone).HasMaxLength(50);
            entity.Property(e => e.DepId).HasColumnName("DepID");
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .HasColumnName("E-mail");
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.OnBoardDate).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.Dep).WithMany(p => p.TEmployees)
                .HasForeignKey(d => d.DepId)
                .HasConstraintName("FK_tEmployee_Department");
        });

        modelBuilder.Entity<TEnterprise>(entity =>
        {
            entity.HasKey(e => e.EnterpriseId).HasName("PK_tSupplier_1");

            entity.ToTable("tEnterprise");

            entity.Property(e => e.EnterpriseId).HasColumnName("EnterpriseID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.EnterpriseName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<TEventLog>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_EventLog");

            entity.ToTable("tEventLog");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EventBrief).HasMaxLength(150);
            entity.Property(e => e.EventDateTime).HasMaxLength(50);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Employee).WithMany(p => p.TEventLogs)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EventLog_tEmployee");
        });

        modelBuilder.Entity<TKeyword>(entity =>
        {
            entity.HasKey(e => e.TagId);

            entity.ToTable("tKeyword");

            entity.Property(e => e.TagId)
                .ValueGeneratedNever()
                .HasColumnName("TagID");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Festival)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Tag)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Topic)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Product).WithMany(p => p.TKeywords)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tKeyword_tProduct");
        });

        modelBuilder.Entity<TLabel>(entity =>
        {
            entity.HasKey(e => e.LabelId).HasName("PK_tSupplier");

            entity.ToTable("tLabel");

            entity.Property(e => e.LabelId)
                .HasComment("")
                .HasColumnName("LabelID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.LabelName)
                .HasMaxLength(50)
                .HasComment("原為供應商名稱、現改為品牌；為維持原有 Database Model 架構，表格名稱不更動");
        });

        modelBuilder.Entity<TMember>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.ToTable("tMember");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Birthday).HasColumnType("date");
            entity.Property(e => e.Cellphone).HasMaxLength(50);
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .HasColumnName("E-mail");
            entity.Property(e => e.MemberName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.Vip).HasColumnName("VIP");
            entity.Property(e => e.Wallet).HasColumnType("money");
        });

        modelBuilder.Entity<TOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("tOrder", tb => tb.HasTrigger("Tri_Transaction_Update"));

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CheckoutAmount).HasColumnType("money");
            entity.Property(e => e.Gui)
                .HasMaxLength(10)
                .HasColumnName("GUI");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RecMemberId).HasColumnName("RecMemberID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Member).WithMany(p => p.TOrders)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_tOrder_tMember");

            entity.HasOne(d => d.Status).WithMany(p => p.TOrders)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_tOrder_tStatus");
        });

        modelBuilder.Entity<TOrderTemp>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("tOrder_temp");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Gui)
                .HasMaxLength(10)
                .HasColumnName("GUI");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RecMemberId).HasColumnName("RecMemberID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<TPackageWayDetail>(entity =>
        {
            entity.HasKey(e => e.PackageWayDetailId);

            entity.ToTable("tPackageWayDetail");

            entity.Property(e => e.PackageWayDetailId).HasColumnName("PackageWayDetailID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PackQty).HasDefaultValueSql("((1))");
            entity.Property(e => e.PackageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PackageID");

            entity.HasOne(d => d.Order).WithMany(p => p.TPackageWayDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_tPackageWayDetail_tOrder");

            entity.HasOne(d => d.Package).WithMany(p => p.TPackageWayDetails)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_tPackageWayDetail_tAllPackage");
        });

        modelBuilder.Entity<TPay>(entity =>
        {
            entity.HasKey(e => e.PayId);

            entity.ToTable("tPay");

            entity.Property(e => e.PayId).HasColumnName("PayID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");

            entity.HasOne(d => d.PayType).WithMany(p => p.TPays)
                .HasForeignKey(d => d.PayTypeId)
                .HasConstraintName("FK_tPay_tPayType");
        });

        modelBuilder.Entity<TPayType>(entity =>
        {
            entity.HasKey(e => e.PayTypeId);

            entity.ToTable("tPayType");

            entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");
            entity.Property(e => e.PayKind).HasMaxLength(50);
            entity.Property(e => e.PayTypeImagePath).HasMaxLength(200);
            entity.Property(e => e.PayTypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<TProdAppearance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tProdAppearance");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.PappearanceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PAppearanceID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Shape).HasMaxLength(50);
            entity.Property(e => e.Size).HasMaxLength(50);

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tProdAppearance_tProduct");
        });

        modelBuilder.Entity<TProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("tProduct");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ActiveId).HasColumnName("ActiveID");
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.LabelId).HasColumnName("LabelID");
            entity.Property(e => e.LaunchTime).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Active).WithMany(p => p.TProducts)
                .HasForeignKey(d => d.ActiveId)
                .HasConstraintName("FK_tProduct_tActive");

            entity.HasOne(d => d.Label).WithMany(p => p.TProducts)
                .HasForeignKey(d => d.LabelId)
                .HasConstraintName("FK_tProduct_tLabel");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.TProducts)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_tProduct_tSubCategory");
        });

        modelBuilder.Entity<TPurchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId);

            entity.ToTable("tPurchase", tb => tb.HasTrigger("Tri_TransactionDetail_Update"));

            entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");
            entity.Property(e => e.Memo).HasMaxLength(250);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseAmount).HasColumnType("money");

            entity.HasOne(d => d.Order).WithMany(p => p.TPurchases)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPurchase_tOrder");

            entity.HasOne(d => d.Product).WithMany(p => p.TPurchases)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tPurchase_tProduct");
        });

        modelBuilder.Entity<TReview>(entity =>
        {
            entity.HasKey(e => e.ReviewId);

            entity.ToTable("tReview");

            entity.Property(e => e.ReviewId).HasColumnName("ReviewID");
            entity.Property(e => e.Comment).HasMaxLength(250);
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");
            entity.Property(e => e.RankId).HasColumnName("RankID");
            entity.Property(e => e.ReviewDate).HasMaxLength(50);

            entity.HasOne(d => d.Member).WithMany(p => p.TReviews)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_tReview_tMember");

            entity.HasOne(d => d.Product).WithMany(p => p.TReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_tReview_tProduct");

            entity.HasOne(d => d.Rank).WithMany(p => p.TReviews)
                .HasForeignKey(d => d.RankId)
                .HasConstraintName("FK_tReview_tAppraisal");
        });

        modelBuilder.Entity<TSale>(entity =>
        {
            entity.HasKey(e => e.SalesId);

            entity.ToTable("tSales");

            entity.Property(e => e.SalesId)
                .ValueGeneratedNever()
                .HasColumnName("SalesID");
            entity.Property(e => e.AgencyId).HasColumnName("AgencyID");
            entity.Property(e => e.DistribuatorId).HasColumnName("DistribuatorID");
            entity.Property(e => e.LabelId).HasColumnName("LabelID");

            entity.HasOne(d => d.Agency).WithMany(p => p.TSales)
                .HasForeignKey(d => d.AgencyId)
                .HasConstraintName("FK_tSales_tAgency");

            entity.HasOne(d => d.Distribuator).WithMany(p => p.TSales)
                .HasForeignKey(d => d.DistribuatorId)
                .HasConstraintName("FK_tSales_tDistributor");

            entity.HasOne(d => d.Label).WithMany(p => p.TSales)
                .HasForeignKey(d => d.LabelId)
                .HasConstraintName("FK_tSales_tLabel");
        });

        modelBuilder.Entity<TStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("tStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName).HasMaxLength(50);
        });

        modelBuilder.Entity<TSubCategory>(entity =>
        {
            entity.HasKey(e => e.SubCategoryId).HasName("PK_SubCategory1");

            entity.ToTable("tSubCategory");

            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.SubCategoryCname)
                .HasMaxLength(200)
                .HasColumnName("SubCategoryCName");
            entity.Property(e => e.SubCategoryName).HasMaxLength(200);

            entity.HasOne(d => d.Category).WithMany(p => p.TSubCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_tSubCategory_tCategory");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
