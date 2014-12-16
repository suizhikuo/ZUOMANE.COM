using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace COM.ZUOMANE.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ArticleContent)
                .IsRequired();

            this.Property(t => t.CreateUser)
                .HasMaxLength(50);

            this.Property(t => t.LastUpdateUser)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Article");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ArticleCategoryID).HasColumnName("ArticleCategoryID");
            this.Property(t => t.ArticleContent).HasColumnName("ArticleContent");
            this.Property(t => t.SortNum).HasColumnName("SortNum");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.RecordStatus).HasColumnName("RecordStatus");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateDatetime).HasColumnName("CreateDatetime");
            this.Property(t => t.LastUpdateUser).HasColumnName("LastUpdateUser");
            this.Property(t => t.LastUpdateDatetime).HasColumnName("LastUpdateDatetime");

            // Relationships
            this.HasRequired(t => t.ArticleCategory)
                .WithMany(t => t.Articles)
                .HasForeignKey(d => d.ArticleCategoryID);

        }
    }
}
