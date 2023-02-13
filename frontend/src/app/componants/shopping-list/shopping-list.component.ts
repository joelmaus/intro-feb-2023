import { Component } from '@angular/core';
import {FormControl, FormGroup } from '@angular/forms';
import { ConsoleReporter } from 'jasmine';
 @Component({
    selector: 'app-shopping-list',
    templateUrl: './shopping-list.component.html',
    styleUrls: ['./shopping-list.component.css']
  })
  export class ShoppingListComponent {   

    form = new FormGroup({
      item: new FormControl('beer')
    });
    
    items: ShoppingItem[] = [
      { description: 'Beer', purchased: false},
      { description: 'Buns', purchased: false},
      { description: 'Eggs', purchased: true}
    ];
markPurchased(item:ShoppingItem){
  item.purchased=true;
}
addItem(){
  console.log(this.form.value);
}

 } type ShoppingItem = {
    description:string,
    purchased: boolean
  }