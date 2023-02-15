import { Injectable } from "@angular/core";
import { Actions, concatLatestFrom, ofType } from "@ngrx/effects";
import { createEffect } from "@ngrx/effects";
import { Store } from "@ngrx/store";
import { tap } from "rxjs";
import { selectCounterFeature } from "..";
import { counterEvents } from "../actions/counter.actions";

@Injectable()
export class CounterEffects {

    saveCounterPrefs$ = createEffect(() => {
        return this.actions$.pipe(
            ofType(counterEvents.countBySet, counterEvents.countDecremented, counterEvents.countIncremented, counterEvents.countReset),
            concatLatestFrom(() => this.store.select(selectCounterFeature)),

        )
    }, { dispatch: false })

    // logItall$ = createEffect(() => {
    //     return this.actions$.pipe(
    //         tap(a => console.log(`Got an action of type ${a.type}`))

    //     )
    // }, { dispatch: false })

    constructor(private actions$: Actions, private store: Store) { }
}