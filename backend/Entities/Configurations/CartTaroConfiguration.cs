using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.Configurations;

public class CartTaroConfiguration : IEntityTypeConfiguration<CartTaro>
{
    public void Configure(EntityTypeBuilder<CartTaro> builder)
    {
        builder.HasData(
            new CartTaro
            {
                Id = 1,
                Name = "Блазень",
                UprightMeaning = "Новий початок, свобода, спонтанність, віра, крок у невідоме.",
                ReversedMeaning = "Безвідповідальність, дурість, ризик без плану, наївність.",
                Keywords = "початок, віра, свобода, ризик"
            },
            new CartTaro
            {
                Id = 2,
                Name = "Маг",
                UprightMeaning = "Воля, ініціатива, сила думки, реалізація задумів.",
                ReversedMeaning = "Маніпуляції, обман, слабка воля, нереалізованість.",
                Keywords = "сила, воля, дія, маніпуляція"
            },
            new CartTaro
            {
                Id = 3,
                Name = "Туз Кубків",
                UprightMeaning = "Любов, нові почуття, емоційна гармонія, натхнення.",
                ReversedMeaning = "Емоційна блокада, втрата радості, фальшиві почуття.",
                Keywords = "любов, почуття, гармонія, натхнення"
            }
        );
    }
}