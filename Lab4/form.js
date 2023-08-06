function validateForm() {
            var name =
                document.forms.RegForm.Name.value;
            var email =
                document.forms.RegForm.EMail.value;
            var phone =
                document.forms.RegForm.Telephone.value;
            var password =
                document.forms.RegForm.Password.value;
            var regEmail=/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/g; 
            var regPhone=/^\d{10}$/;                                        
            var regName = /\d+$/g;     
            var regPassword = /^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[A-Z])[a-zA-Z0-9!@#$%^&*]{8,15}$/;
                                           
        
            if (name == "" || regName.test(name)) {
                window.alert("Please enter your name properly.");
                name.focus();
                return false;
            }
        
            
            if (email == "" || !regEmail.test(email)) {
                window.alert("Please enter a valid e-mail address.");
                email.focus();
                return false;
            }
             

            if (password == "" ||regPassword.test(password) || password.length <6) {
                alert("Password must be between 8-15 characters long, contain at least one numeric, one special character, and one uppercase letter.");
                password.focus();
                return false;
            }
           
            if (phone == "" || !regPhone.test(phone)) {
                alert("Please enter valid phone number.");
                phone.focus();
                return false;
            }
        
            return true;
        }