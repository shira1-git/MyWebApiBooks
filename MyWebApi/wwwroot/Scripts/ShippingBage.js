<<<<<<< HEAD

window.addEventListener("load", async function () {
    console.log("startup ShoppingBag");
    try {
        await getAllMyProducts();
        showAmountAndPrice();
    } catch (error) {
        console.error("Error loading products:", error);
    }
});

const getAllMyProducts = async () => {
    try {
        const userBasket = JSON.parse(sessionStorage.getItem("basket")) || [];
        console.log(userBasket);
        const template = document.getElementById('temp-row');
        userBasket.forEach(basket => displayProduct(basket, template));
    } catch (error) {
        console.error("Failed to get products from basket:", error);
    }
};

const displayProduct = (basket, template) => {
    try {
        console.log(basket.productName);
        const clone = template.content.cloneNode(true);
        const item = clone.querySelector(".item-row");
        item.querySelector(".nameColumn").textContent = basket.productName;
        item.querySelector(".descriptionColumn").textContent = basket.description;
        item.querySelector(".quantityColumn").textContent = basket.quentity;
        item.querySelector(".priceColumn").textContent = basket.price * basket.quentity;

        const deleteButton = clone.querySelector('.DeleteButton');
        deleteButton.addEventListener('click', () => removeProductFromBasket(basket));

        document.querySelector(".items tbody").appendChild(clone);
    } catch (error) {
        console.error("Error displaying product:", error);
    }
};

const showAmountAndPrice = () => {
    try {
        const userBasket = JSON.parse(sessionStorage.getItem("basket")) || [];
        console.log(userBasket);
        let totalPrice = 0;
        let amount = 0;

        userBasket.forEach(product => {
            totalPrice += product.price * product.quentity;
            amount += product.quentity;
        });

        document.getElementById("itemCount").textContent = amount;
        document.getElementById("totalAmount").textContent = totalPrice;
        console.log(totalPrice, amount);
    } catch (error) {
        console.error("Error calculating total amount and price:", error);
    }
};

const placeOrder = async () => {
    try {
        await createOrder();
        sessionStorage.setItem("basket", "[]");
        clearScreen();
        showAmountAndPrice();
    } catch (error) {
        console.error("Failed to place order:", error);
    }
};

const createOrder = async () => {
    try {
        const products = await getProductsFromBasket();
        console.log("products", products);
        const data = formatOrderData(products);
        console.log("data", data);

        const response = await fetch("api/Order", {
=======
window.addEventListener("load", function () {
    console.log("startUp ShippingBag");
    getAllMyProducts();
    showAmmontPrice()
});


const getAllMyProducts =async  () => {
    let userBasket =await JSON.parse(sessionStorage.getItem("basket"));
    console.log(userBasket);
    //const template = document.querySelector("#item-row");
    const template = document.getElementById('temp-row');
    userBasket.forEach(basket => ShowBasketProducts(basket, template));
}

const ShowBasketProducts = (basket, template) => {
    console.log(basket.productName)
    const clone = template.content.cloneNode(true);
    //let item = clone.querySelector("td");
    let item = clone.querySelector(".item-row");
    item.querySelector(".nameColumn").textContent = basket.productName;
    item.querySelector(".descriptionColumn").textContent = basket.description;
    item.querySelector(".quantityColumn").textContent = basket.quentity;
    item.querySelector(".priceColumn").textContent = basket.price * basket.quentity;
    const deleteButton = clone.querySelector('.DeleteButton');

    deleteButton.addEventListener('click', function () {
        deleteProductFromBasket(basket)
    });

    document.querySelector(".items tbody").appendChild(clone);
}

const showAmmontPrice = () => {
    let userBasket = JSON.parse(sessionStorage.getItem("basket"));
    console.log(userBasket)
    let totalPrice = 0;
    let ammount = 0;
    userBasket.map(prod => {
        totalPrice += prod.price*prod.quentity;
        ammount +=prod.quentity;
    })
    document.getElementById("itemCount").innerHTML=ammount
    document.getElementById("totalAmount").innerHTML=totalPrice
    console.log(totalPrice,ammount)
}

const placeOrder =async () => {
    //send to server
    await creatOrder()
    window.sessionStorage.setItem("basket", "[]");
    CleanTheScreen()
    showAmmontPrice()
}

const creatOrder = async() => {
    let products = JSON.parse(window.sessionStorage.getItem("basket"));
    products = products.map(ele => {
        return {
            productId: ele.productId, price: ele.price,quentity: ele.quentity };
    })
    console.log(products)
    const data = {
        userId: JSON.parse(window.sessionStorage.getItem("userID")),
        orderItems: products
    }

    console.log(data)
    const respones = await fetch("api/Order",
        {
>>>>>>> 288bcff (add configuration)
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
<<<<<<< HEAD

        if (!response.ok) {
            alert("Request failed");
            return;
        }

        const result = await response.json();
        if (!result) {
            alert("Order not found");
        } else {
            alert("Order added to your account: " + result.id);
            return result;
        }
    } catch (error) {
        console.error("Error creating order:", error);
        alert("An error occurred while creating the order");
    }
};

const getProductsFromBasket = async () => {
    try {
        const products = JSON.parse(sessionStorage.getItem("basket")) || [];
        return products.map(product => ({
            productId: product.productId,
            price: product.price,
            quentity: product.quentity
        }));
    } catch (error) {
        console.error("Failed to get products from basket:", error);
        return [];
    }
};

const formatOrderData = (products) => {
    try {
        return {
            userId: JSON.parse(sessionStorage.getItem("userID")),
            orderItems: products
        };
    } catch (error) {
        console.error("Error formatting order data:", error);
    }
};

const clearScreen = () => {
    try {
        const parentElement = document.querySelector(".items tbody");
        while (parentElement.firstChild) {
            parentElement.removeChild(parentElement.firstChild);
        }
    } catch (error) {
        console.error("Error clearing the screen:", error);
    }
};

const removeProductFromBasket = async (product) => {
    try {
        let userBasket = JSON.parse(sessionStorage.getItem("basket")) || [];
        userBasket.forEach(p => {
            if (isSameProduct(p, product)) {
                p.quentity -= 1;
            }
        });
        await updateBasket(userBasket);
        location.reload();
    } catch (error) {
        console.error("Failed to remove product from basket:", error);
    }
};

const isSameProduct = (prod, product) => {
    return (
        prod.productName === product.productName &&
        prod.price === product.price &&
        prod.categoryId === product.categoryId &&
        prod.description === product.description
    );
};

const updateBasket = (userBasket) => {
    try {
        userBasket = userBasket.filter(prod => prod.quentity > 0);
        sessionStorage.setItem("basket", JSON.stringify(userBasket));
    } catch (error) {
        console.error("Failed to update basket:", error);
    }
};
=======
    if (!respones.ok) {
        alert("in correct")
    }
    else {
        const result = await respones.json()
        if (!result) {
            alert("not found")
        }
        else {
            //console.log("bcbcbnv",result.id)
            alert("added to yuor account " + result.id)
        }
        return result
    }
}

const CleanTheScreen = () => {
    const parentElement = document.getElementById('items');
    while (parentElement.firstChild) {
        parentElement.removeChild(parentElement.firstChild);
    }
}

const deleteProductFromBasket = (product) => {
    let userBasket = JSON.parse(sessionStorage.getItem("basket"));
    userBasket.map(prod => { 
    if (prod.productName == product.productName && prod.price == product.price && prod.categoryId == product.categoryId && prod.description == product.description ) {
        prod.quentity -= 1;
        
    }
    })
    userBasket = userBasket.filter(prod => prod.quentity > 0)
    window.sessionStorage.setItem("basket", JSON.stringify(userBasket));
    location.reload()
}
>>>>>>> 288bcff (add configuration)
