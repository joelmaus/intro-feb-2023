import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { selectCounterCurrent } from 'src/app/state';

@Component({
    selector: 'app-counter',
    templateUrl: './counter.component.html',
    styleUrls: ['./counter.component.css']
})
export class CounterComponent {

    current$ = this.store.select(selectCounterCurrent)
    constructor(private store: Store) { }

    increment() {
        this.store.dispatch({ type: 'They clicked the increment button' })
    }

    decrement() {
        this.store.dispatch({ type: 'They done clicked the decrement button' })
    }
}
