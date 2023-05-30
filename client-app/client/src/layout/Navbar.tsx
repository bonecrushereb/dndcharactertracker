import { Container, Menu } from "semantic-ui-react";

export default function Navbar() {
    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    DND character tracker
                </Menu.Item>
            </Container>
        </Menu>
    );
}