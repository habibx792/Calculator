console.log("Hello");
let value = "";
let oper = "";
const Buttons = document.querySelectorAll(".button");
const input = document.querySelector(".input");
console.log(Buttons);
Buttons.forEach((btn)=>{
  btn.title=btn.textContent;
})
Buttons.forEach((btn) => {
  btn.addEventListener("click", () => {
    if (btn.textContent === "1") {
      value += 1;

      console.log(value);
     
      input.value = value;
    } else if (btn.textContent === "2") {
      value += 2;
      input.value = value;
      
      console.log(value);
    } else if (btn.textContent === "3") {
      value += 3;
      console.log(value);
      input.value = value;
      
    } else if (btn.textContent === "4") {
      value += 4;
      input.value = value;
      console.log(value);
    } else if (btn.textContent === "5") {
      value += 5;
      input.value = value;
    
      console.log(value);
    } else if (btn.textContent === "6") {
      value += 6;
      input.value = value;
      console.log(value);
     
    } else if (btn.textContent === "7") {
      value += 7;
      input.value = value;


      console.log(value);
    } else if (btn.textContent === "8") {
      value += 8;
      
      btn.title = btn.textContent;
      console.log(value);
    } else if (btn.textContent === "9") {
      value += 9;
     
      btn.title = btn.textContent;
      console.log(value);
    } else if (btn.textContent === "0") {
      value += 0;
      console.log(value);
      input.value = value;
      btn.title = btn.textContent;
    } else if (btn.textContent === "D") {
      value = value.slice(0, -1);
      input.value = value;
    } else if (btn.textContent === "%") {
      value += "%";
      input.value = value;
    } else if (btn.textContent === "π") {
      value += Math.PI;
      input.value = value;
    } else if (btn.textContent === "C") {
      value = "";
      console.log(value);
      input.value = value;
    } else if (btn.textContent === ".") {
      value += ".";
      console.log(value);
      input.value = value;
    } else if (btn.textContent === "+") {
      if (input.value === "") {
        value = value;
      } else {
        value = input.value;
        value += "+";
        input.value = value;
        console.log(value);
      }
    } else if (btn.textContent === "-") {
      if (input.value === "") {
        value = value;
      } else {
        value = input.value;
        value += "-";
        input.value = value;
        console.log(value);
      }
    } else if (btn.textContent === "X") {
      if (input.value === "") {
        value = value;
      } else {
        value = input.value;
        value += "*";
        input.value = value;
        console.log(value);
      }
    } else if (btn.textContent == "/") {
      if (input.value === "") {
        value = value;
        btn.focus();
        setTimeout(() => {
          btn.blur(), 50;
        }, 1000);
      } else {
        value = input.value;
        value += "/";
        input.value = value;
        console.log(value);
      }
    }
    if (btn.textContent == "=") {
      try {
        value = input.value;
        const result = eval(value);
        value = "";
        input.value = result;
      } catch {
        input.value = "!";
        setTimeout(() => {
          input.value = value;
        }, 1000);
      }
    }
  });
});
