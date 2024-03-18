class Student {
  private _fullName: string;

  constructor(public firstName: string, public lastName: string) {
    this._fullName = `${firstName} ${lastName}`;
  }

  public get fullName(): string {
    return this._fullName;
  }
}

interface Person {
  firstName: string;
  lastName: string;
}

function greeter(person: Person) {
  return 'Olá, ' + person.firstName + ' ' + person.lastName;
}

const user = new Student('Murilo', 'Sanches');

function TSButton() {
  document.getElementById('ts-example').innerHTML = greeter(user);
}
