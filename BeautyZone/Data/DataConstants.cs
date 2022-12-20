namespace BeautyZone.Data
{
    public class DataConstants
    {
        public class User
        {
            public const int FullNameMinLength = 5;
            public const int FullNameMaxLength = 50;
            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 20;
        }

        public class MedicalCenter
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 30;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 400;
            public const int JoiningCodeMinLength = 4;
            public const int JoiningCodeMaxLength = 12;
            public const int AdressNameMinLength = 7;
            public const int AddressNameMaxLength = 50;
            public const string DefaultImageUrl = "https://scontent.fsof8-1.fna.fbcdn.net/v/t39.30808-6/305207276_500645628727160_5532865874823203762_n.png?_nc_cat=102&ccb=1-7&_nc_sid=e3f864&_nc_ohc=ccQ7EYXVnn4AX8ZUk3g&_nc_ht=scontent.fsof8-1.fna&oh=00_AfBlNuBu9hUjlpR3UimYOSvvk9jPX5q_22Ml6-rm6PvUoQ&oe=63A6CBB5";
        }

        public class Physician
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;
            public const string DefaultMaleImageUrl = "https://img.freepik.com/premium-photo/happy-successful-male-cosmetologist-background-beauty-office-portrait-man-beautician_154092-14504.jpg?w=1060";
            public const string DefaultFemaleImageUrl = "https://media.istockphoto.com/id/1280387272/photo/woman-cosmetologist-or-dermatologist-looking-at-camera-in-beauty-spa-salon-room.jpg?s=612x612&w=is&k=20&c=hdR5i0xQ0hx4ip8WrILUiHXFTGHz5jice6WljRieHvM=";
            public const string GenderMale = "Female";
            public const int ExaminationPriceMinValue = 0;
            public const int ExaminationPriceMaxValue = 600;
            public const int PermissionPracticeMinLength = 8;
            public const int PermissionPracticeMaxLength = 20;
        }

        public class Patient
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 40;
        }

        public class Speciality
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 20;

        }

        public class County
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 70;
            public const int Alpha3CodeMinLength = 3;
            public const int Alpha3CodeMaxLength = 3;
        }

        public class City
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
        }

        public class MedicalCenterType
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 20;
        }

        public class Review
        {
            public const int RatingMinValue = 1;
            public const int RatingMaxValue = 5;
            public const int CommentMaxLength = 100;
        }
    }
}
