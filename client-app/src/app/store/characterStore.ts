import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Character } from "../models/character"
import {v4 as uuid} from 'uuid';

export default class CharacterStore {
    characters: Character[] = [];
    selectedCharacter: Character | undefined = undefined;

  constructor() {
    makeAutoObservable(this)
  }
  
  loadCharacters = async() => {
    try {
      const characters = await agent.Characters.list();
      console.log(characters);
        characters.forEach(character => {
          this.characters.push(character);
        })
    } catch (error) {
      console.log(error);
    }
  }

  createCharacter = async (character: Character) => {
    character.id = uuid();
    try {
      await agent.Characters.create(character);
      runInAction(() => {
        this.characters.push(character);
        this.selectedCharacter = character;
      })
    } catch (error) {
      console.log(error);
    }
  }
}