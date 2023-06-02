import React from "react";
import { Card, Icon, Label } from 'semantic-ui-react'
import { Character } from "../../../app/models/character";

interface Props {
    character: Character
}


export default function CharacterDetails({character}: Props) {
    return (
        <Card>
        <Card.Content>
          <Card.Header>{character.name}</Card.Header>
          <Card.Meta>
            {character.race} - {character.class} - {character.level}
          </Card.Meta>
          <Label>

          </Label>
          <Card.Description>
            Matthew is a musician living in Nashville.
          </Card.Description>
        </Card.Content>
        <Card.Content extra>
          <a>
            <Icon name='user' />
            22 Friends
          </a>
        </Card.Content>
      </Card>
    );
}