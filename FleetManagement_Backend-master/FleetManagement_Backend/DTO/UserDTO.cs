namespace FleetManagement_Backend.DTO
{
    public class UserDTO
    {
        private String? firstname { get; set; }
        private String? lastname { get; set; }
        private String? mobilenumber { get; set; }
        private String? email { get; set; }
        private String? address { get; set; }
        private String? dlNo { get; set; }
        private long? aadharNo { get; set; }
        private long? passportNo { get; set; }
        private int? cityId { get; set; }
        private int? stateId { get; set;}

        public String ToString()
        {
            return "UserDTO [firstName=" + firstName + ", lastName=" + lastName + ", mobileNumber=" + mobileNumber
                    + ", emailId=" + emailId + ", address=" + address + ", dlNo=" + dlNo + ", aadharNo=" + aadharNo
                    + ", passportNo=" + passportNo + ", cityId=" + cityId + ", stateId=" + stateId + "]";
        }
    }
}
