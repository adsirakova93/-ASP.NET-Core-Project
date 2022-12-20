﻿namespace BeautyZone
{
    public class WebConstants
    {
        public const string PatientRoleName = "Patient";
        public const string PhysicianRoleName = "Therapist";

        public const string GlobalSuccessMessageKey = "GlobalSuccessMessage";
        public const string GlobalErrorMessageKey = "GlobalErrorMessage";

        public const string UserRegistrationSuccessMessage = "Successful registration. Use the 'Become' button to complete your profile.";

        public const string BecomePhysicianSuccessMessage = "Therapist profile was created successfullly and is awaiting approval. Login again if you want to edit it.";
        public const string BecomePatientSuccessMessage = "Patient profile was created successfully. Login again, please.";

        public const string EditPhysicianSuccessMessage = "Therapist profile was edited successfully and is awaiting approval.";
        public const string AdminEditPhysicianSuccessMessage = "Therapist profile was edited successfully.";
        public const string EditPatientSuccessMessage = "Patient profile was edited successfully.";

        public const string AlreadyCreatorOfMedicalCenter = "You're already a creator of a Beauty Center. Please, edit it's information instead.";

        public const string CreateMedicalCenterSuccessMessage = "Beauty Center '{0}' was created successfully.";
        public const string EditMedicalCenterSuccessMessage = "Beauty Center '{0}' was edited successfully.";
        public const string EditMedicalCenterErrorMessage = "Beauty Center can be edited only by it's creator.";
        public const string CreateMedicalCenterCityAndCountryDontMatchMessage = "City does not match the Country.";

        public const string BookAppointmentSuccessMessage = "Appointment booked succesfully.";
        public const string AppointmentNotAvailableMessage = "Appointment at {0} : {1} is not available. Please, choose another date or hour.";

        public const string AddSpecialitySuccessMessage = "Speciality '{0}' was added successfully.";
        public const string AddMedicalCenterTypeSuccessMessage = "Beauty Center Type '{0}' was added successfully.";
        public const string AddCountrySuccessMessage = "Country '{0}, {1}' was added successfully.";
        public const string AddCitySuccessMessage = "City '{0}' was added successfully.";

        public const string WriteReviewSuccessMessage = "A Review was writtern succesfully.";
    }
}
