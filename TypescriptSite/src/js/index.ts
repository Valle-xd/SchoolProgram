class Car {
    Brand: string;
    Model: string;
    Year: string;
}

let NiceArray: Array<Car> = new Array<Car>();
let pos:number = 0;


let Car1:Car = {Brand:"BMW", Model:"s60", Year:"2010"}
let Car2:Car = {Brand:"Skoda", Model:"c20", Year:"2019"}
let Car3:Car = {Brand:"hufsa", Model:"dsa", Year:"3214321"}
NiceArray.push(Car1);
NiceArray.push(Car2);
NiceArray.push(Car3);

function CarInfo(car:Car):string {
    return car.Brand +" "+ car.Model +" "+ car.Year
}

let element1:HTMLDivElement = <HTMLDivElement> document.getElementById("content1");
element1.innerHTML = "Cars here soon :)";
//let element2:HTMLDivElement = <HTMLDivElement> document.getElementById("content2");
//element2.innerHTML = CarInfo(Car2);


let Knap:HTMLButtonElement = <HTMLButtonElement> document.getElementById("Knap");
//Knap.innerHTML="YES";

Knap.addEventListener("click", MouseEvent =>{
    if (pos > NiceArray.length-1){
        pos = 0;
    }
    element1.innerHTML = CarInfo(NiceArray[pos]);
    pos++;
});