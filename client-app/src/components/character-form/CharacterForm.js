import React, { useState } from 'react';
import PropTypes from 'prop-types';
import { connect } from 'react-redux';
import { createCharacter } from '../../actions/character';
import { Form, Input } from 'semantic-ui-react';

const initialState = {
    characterName: '',
    playerName: '',
    level: '',
    race: '',
    characterClass: '',
    alignment: '',
    strength: '',
    dexterity: '',
    constitution: '',
    intelligence: '',
    wisdom: '',
    charisma: '',
    proficiency: '',
    speed: '',
    abilities: '',
    background: '',
    skillproficiencies: '',
    toolproficiencies: '',
    languages: '',
    personalityTrait: '',
    ideals: '',
    bonds: '',
    flaws: '',
    organizations: '',
    allies: '',
    enemies: '',
    backstory: '',
    equipment: []
}

const CharacterForm = ({ 
  createCharacter
}) => {
  const [formData, setFormData] = useState(initialState);


  const {
    characterName,
    playerName,
    level,
    race,
    characterClass,
    alignment,
    strength,
    dexterity,
    constitution,
    intelligence,
    wisdom,
    charisma,
    proficiency,
    speed,
    abilities,
    background,
    skillproficiencies,
    toolproficiencies,
    languages,
    personalityTrait,
    ideals,
    bonds,
    flaws,
    organizations,
    allies,
    enemies,
    backstory,
    equipment
} = formData;

const onChange = (e) => {
  setFormData({ ...formData, [e.target.name]: e.target.value });
}

const onSubmit = (e) => {
  e.PreventDefault();
  createCharacter(formData)
}

  return (
    <section>
      <h1>Create Your Character</h1>
      <Form onSubmit={onSubmit}>
        <Form.Group widths='equal'>
          <Form.Field control={Input} placeholder='Character Name' value={characterName} onChange={onChange} style={{width: '40%', marginTop: '20px'}}/>
        </Form.Group>
        <Form.Group style={{float: 'right', marginRight: '20px', marginBottom: '5px', marginTop:'-60px'}}>
          <Form.Field control={Input} placeholder='Level' name='level' value={level} onChange={onChange} style={{width: '75px'}} />
          <Form.Field control={Input} placeholder='Class' name='characterClass' value={characterClass} onChange={onChange} />
          <Form.Field control={Input} placeholder='Background' name='background' value={background} onChange={onChange}/>
          <Form.Field control={Input} placeholder='Player Name' name='playerName' value={playerName} onChange={onChange}/>
          </Form.Group>
        <Form.Group style={{float: 'right', marginRight: '15%'}}>
          <Form.Field control={Input} placeholder='Race' name='race' value={race} onChange={onChange} style={{marginTop: '10px'}} />
          <Form.Field control={Input} placeholder='Alignment' name='alignment' value={alignment} onChange={onChange} style={{marginTop: '10px', width: '200px'}} />
        </Form.Group>
        <Form.Group style={{marginTop: '150px'}}>
        <Form.Field control={Input} placeholder='strength' name='strength' value={strength} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='dexterity' name='dexterity' value={dexterity} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='constitution' name='constitution' value={constitution} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='intelligence' name='intelligence' value={intelligence} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='wisdom' name='wisdom' value={wisdom} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='charisma' name='charisma' value={charisma} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='proficiency' name='proficiency' value={proficiency} onChange={onChange} style={{width: '110px'}}/>
        <Form.Field control={Input} placeholder='speed' name='speed' value={speed} onChange={onChange} style={{width: '110px'}}/>


        </Form.Group>
        <input type="text" placeholder='abilities' name='abilities' value={abilities} onChange={onChange}></input>
        <input type="text" placeholder='skillproficiencies' name='skillproficiencies' value={skillproficiencies} onChange={onChange}></input>
        <input type="text" placeholder='toolproficiencies' name='toolproficiencies' value={toolproficiencies} onChange={onChange}></input>
        <input type="text" placeholder='languages' name='languages' value={languages} onChange={onChange}></input>
        <input type="text" placeholder='personalityTrait' name='personalityTrait' value={personalityTrait} onChange={onChange}></input>
        <input type="text" placeholder='ideals' name='ideals' value={ideals} onChange={onChange}></input>
        <input type="text" placeholder='bonds' name='bonds' value={bonds} onChange={onChange}></input>
        <input type="text" placeholder='flaws' name='flaws' value={flaws} onChange={onChange}></input>
        <input type='text' placeholder='organizations' name='organizations' value={organizations} onChange={onChange} />
        <input type="text" placeholder='allies' name='allies' value={allies} onChange={onChange}></input>
        <input type="text" placeholder='enemies' name='enemies' value={enemies} onChange={onChange}></input>
        <textarea type="text" placeholder='backstory' name='backstory' value={backstory} onChange={onChange}></textarea>
        <input type="text" placeholder='equipment' name='equipment' value={equipment} onChange={onChange}></input>
        <input type='submit' />
      </Form>
    </section>
  )
}

CharacterForm.propTypes = {
  createCharacter: PropTypes.func.isRequired,
}

export default connect(null, {createCharacter})(CharacterForm)