<<<<<<< HEAD
/*let thisUser = {}
let id = 0;

const handelRegister = async (data) => {
    console.log("ddddd" + data.Email)
    const checkValid = await validateEmail(data.Email)
    console.log(checkValid)
    if (checkValid==true) {
        sendToRegister(data)
    }
=======
let thisUser = {}
let id=0;

const handelRegister = async (data) => {
    console.log("ddddd" + data.Email)
    const checkValid = await validateEmail(data.email)
    console.log(checkValid)
    if (checkValid)
        sendToRegister(data)
>>>>>>> 288bcff (add configuration)
    else {
        alert("invalid email!")
    }
}

const sendToRegister = async (data) => {
    const respones = await fetch("api/User/register",
        {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
    try {
        const user = await respones.json()
        if (user) {
            alert("add successfully")
        }
    }
    catch {
        alert("try again")
    }
}

const handelLogin = async () => {
    const userName = document.getElementById("UserName").value;
    const password = document.getElementById("Password").value;
    const user = { userName: userName, password: password }
    const respones = await fetch("api/User/login",
        {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(user)
        });
    if (!respones.status == 200) {
        alert("Unauthorized")
    }
    else {
        const data = await respones.json()
        alert("welcome to!! " + data.userName)
        console.log(data.userId)
        sessionStorage.setItem("userID", data.userId);
<<<<<<< HEAD
        sessionStorage.setItem("basket", "[]")
        window.location.replace("Products.html")
    }

}
=======
        sessionStorage.setItem("basket","[]")
        window.location.replace("Products.html")
    }

    }
>>>>>>> 288bcff (add configuration)

const showReg = () => {
    document.getElementById("reg").style.display = "block"
}

<<<<<<< HEAD
const checkStrong = async (data) => {
    try {
        const response = await fetch("api/User/check", {
=======
//const showUpdate = () => {
//    document.getElementById("update").style.display = "block"
//}

//const handelUpdate = async () => {
//    const userId = sessionStorage.getItem("userID");
//    const userName = document.getElementById("UserName").value;
//    const LastName = document.getElementById("LastName").value;
//    const Password = document.getElementById("Password").value;
//    const firstName = document.getElementById("FirstName").value;

//    const user = { userName: userName, lastName: LastName, Password: Password, firstName: firstName ,userId:userId}
//    var respones = await fetch(`api/User/${userId}`,
//        {
//            method: "PUT",
//            headers: {
//                'Content-Type': "application/json"
//            },
//            body: JSON.stringify(user)

//        })
    
//    if (respones.status == 204) {
//        alert("can't update")
//    }
//    else {
//        alert("Updated succeded")
//    }
//}

const checkStrong = async (data) => {
    const respones = await fetch("api/User/check",
        {
>>>>>>> 288bcff (add configuration)
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
<<<<<<< HEAD

        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const result = await response.json();
        const colorElement = document.getElementById("check");

        switch (result) {
            case 0:
                colorElement.style.setProperty("background-color", "red");
                break;
            case 1:
                colorElement.style.setProperty("background-color", "orange");
                break;
            default:
                if (result >= 2) {
                    colorElement.style.setProperty("background-color", "green");
                    showRegister();
                }
                break;
        }

        return result;
    } catch (error) {
        console.error('There was a problem with the fetch operation:', error);
    }
};
=======
    const result = await respones.json()
    if (result == 0) {
        let color = document.getElementById("check")
        color.style.setProperty("background-color", "red")
    }
    if (result == 1) {
        let color = document.getElementById("check")
        color.style.setProperty("background-color", "orange")
    }
    if (result >= 2) {
        let color = document.getElementById("check")
        color.style.setProperty("background-color", "green")
        showRegister()
    }
    return result;
}
>>>>>>> 288bcff (add configuration)

const showRegister = () => {
    document.getElementById("register").style.display = "block"
}

function validateEmail(email) {
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailPattern.test(email);
<<<<<<< HEAD
    
}
*/

let thisUser = {};
let userId = 0;

const handleRegister = async (data) => {
    console.log("Email:", data.Email);
    const isEmailValid = await validateEmail(data.Email);
    console.log("Email validation result:", isEmailValid);

    if (isEmailValid) {
        await registerUser(data);
    } else {
        alert("Invalid email!");
    }
};

const registerUser = async (data) => {
    try {
        const response = await fetch("api/User/register", {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });

        const user = await response.json();
        if (user) {
            alert("Registration successful");
        }
    } catch (error) {
        console.error("Error during registration:", error);
        alert("Please try again later");
    }
};

const handleLogin = async () => {
    const userName = document.getElementById("UserName").value;
    const password = document.getElementById("Password").value;
    const user = { userName, password };

    try {
        const response = await fetch("api/User/login", {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(user)
        });

        if (response.status !== 200) {
            alert("Unauthorized");
        } else {
            const data = await response.json();
            alert(`Welcome ${data.userName}`);
            console.log("User ID:", data.userId);

            sessionStorage.setItem("userID", data.userId);
            sessionStorage.setItem("basket", "[]");
            window.location.replace("Products.html");
        }
    } catch (error) {
        console.error("Login error:", error);
        alert("Login failed, please try again");
    }
};

const showRegistrationForm = () => {
    document.getElementById("reg").style.display = "block";
};

const checkPasswordStrength = async (data) => {
    try {
        const response = await fetch("api/User/check", {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });

        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        const result = await response.json();
        const colorElement = document.getElementById("check");

        switch (result) {
            case 0:
                colorElement.style.backgroundColor = "red";
                break;
            case 1:
                colorElement.style.backgroundColor = "orange";
                break;
            default:
                if (result >= 2) {
                    colorElement.style.backgroundColor = "green";
                    showRegistration();
                }
                break;
        }

        return result;
    } catch (error) {
        console.error('There was a problem with the fetch operation:', error);
    }
};

const showRegistration = () => {
    document.getElementById("register").style.display = "block";
};

const validateEmail = (email) => {
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailPattern.test(email);
};
=======
}


>>>>>>> 288bcff (add configuration)
