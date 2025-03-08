using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.HasKey(u => u.Id);  // Primary Key
        builder.Property(u => u.Email).HasMaxLength(20);
        //configure gender
        //configure email to has @
        //configure phone to have only numbers
        //configure year of birth to be less than 2010
        //configure the payment method
        //configure the id to be auotincrement for all classes
        //configure default values here
        
    }
}
