<<<<<<< HEAD

let currentUser = {};
let userId;

const getDetails = (user) => {
    console.log(user);
    currentUser = user;
    userId = user.id;
    alert(userId);
};

const showUpdateForm = () => {
    document.getElementById("update").style.display = "block";
};

const handleUpdate = async () => {
    const userId = sessionStorage.getItem("userID");
    const userName = document.getElementById("UserName").value;
    const lastName = document.getElementById("LastName").value;
    const password = document.getElementById("Password").value;
    const firstName = document.getElementById("FirstName").value;
    const email = document.getElementById("Email").value;

    let updatedUser = {};

    if (userName !== "") updatedUser.userName = userName;
    if (lastName !== "") updatedUser.lastName = lastName;
    if (password !== "") updatedUser.password = password;
    if (firstName !== "") updatedUser.firstName = firstName;
    if (email !== "") updatedUser.email = email;

    console.log(updatedUser);

    try {
        const response = await fetch(`api/User/${userId}`, {
            method: "PUT",
            headers: { 'Content-Type': "application/json" },
            body: JSON.stringify(updatedUser)
        });

        if (response.status === 204) {
            alert("Update failed");
        } else {
            alert("Update succeeded");
        }
    } catch (error) {
        console.error("Error updating user:", error);
    }
};

const backToShopping = () => {
    window.location.replace("Products.html");
};

const checkPasswordStrength = async (data) => {
    try {
        const response = await fetch("api/User/check", {
=======
let thisUser = {}
let id;

const getDetailes = (user) => {
    console.log(user);
    thisUser = user;
    id = user.id;
    alert(id)
}

//const showUpdate = () => {
//    document.getElementById("update").style.display = "block"
//}

//const handelUpdate = async (data) => {
//    const respones = await fetch(`api/User/${id}`,
//        {
//            method: 'PUT',
//            headers: { 'Content-Type': 'application/json' },
//            body: JSON.stringify(data)
//        });
//    const user = await respones.json()
//}
const showUpdate = () => {
    document.getElementById("update").style.display = "block"
}

const handelUpdate = async () => {
    const userId = sessionStorage.getItem("userID");
    const userName = document.getElementById("UserName").value;
    const LastName = document.getElementById("LastName").value;
    const Password = document.getElementById("Password").value;
    const firstName = document.getElementById("FirstName").value;

    const user = { userName: userName, lastName: LastName, Password: Password, firstName: firstName, userId: userId }
    var respones = await fetch(`api/User/${userId}`,
        {
            method: "PUT",
            headers: {
                'Content-Type': "application/json"
            },
            body: JSON.stringify(user)

        })

    if (respones.status == 204) {
        alert("can't update")
    }
    else {
        alert("Updated succeded")
    }
}

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
                colorElement.style.backgroundColor = "red";
                break;
            case 1:
                colorElement.style.backgroundColor = "orange";
                break;
            default:
                if (result >= 2) {
                    colorElement.style.backgroundColor = "green";
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
    }
    return result;
}

const BackToShopping = () => {
    window.location.replace("Products.html")
}
>>>>>>> 288bcff (add configuration)
