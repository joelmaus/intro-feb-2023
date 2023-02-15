

// The "Application State"

import { ActionReducerMap } from "@ngrx/store";
import { CounterState, reducer } from './reducers/counter.reducer'

export interface AppState {
    counter: CounterState
};


export const reducers: ActionReducerMap<AppState> = {
    counter: reducer
}
