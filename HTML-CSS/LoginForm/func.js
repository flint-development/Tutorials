document.getElementById('showPassword').onclick = function () {
    if (this.checked) {
        document.getElementById('passwrd').type = "text";
    } else {
        document.getElementById('passwrd').type = "password";
    }
};