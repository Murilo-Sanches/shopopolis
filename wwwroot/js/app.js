var Student = /** @class */ (function () {
    function Student(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        this._fullName = "".concat(firstName, " ").concat(lastName);
    }
    Object.defineProperty(Student.prototype, "fullName", {
        get: function () {
            return this._fullName;
        },
        enumerable: false,
        configurable: true
    });
    return Student;
}());
function greeter(person) {
    return "Olá, " + person.firstName + " " + person.lastName;
}
var user = new Student("Murilo", "Sanches");
function TSButton() {
    document.getElementById("ts-example").innerHTML = greeter(user);
}
//# sourceMappingURL=app.js.map