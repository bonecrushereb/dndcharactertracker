import { createContext, useContext } from 'react';
import CharacterStore from './characterStore'

interface Store{
    characterStore: CharacterStore
}

export const store: Store = {
    characterStore: new CharacterStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext)
}



