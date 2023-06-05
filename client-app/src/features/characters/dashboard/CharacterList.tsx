import React from "react";
import { Character } from "../../../app/models/character";
import { Button, Item, Segment } from "semantic-ui-react";

interface Props {
    characters: Character[];
}

export default function CharacterList({characters}: Props) {
    return (
        <Segment>
            <Item.Group divided>
                {characters.map(character => (
                    <Button style={{width: '100%', margin: '2px'}}>
                    <Item key={character.id}>
                        <Item.Content>
                            <Item.Header as='a'>{character.name}</Item.Header>
                            <Item.Meta>{character.class} - {character.level}</Item.Meta>
                        </Item.Content>
                    </Item>
                    </Button>
                ))}
            </Item.Group>
        </Segment>
    );
}