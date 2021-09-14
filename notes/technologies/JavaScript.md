# JavaScript

## Emoji Regex

```javascript
text.match(/\p{Emoji}/gu);

// Example
const data = ['Hey 😘 wassup? 😁', 'HBD 🎂 sweetheart 💖']
const extractEmojis = (text) => text.match(/\p{Emoji}/gu)

data.map(extractEmojis)     // => [['😘', '😁'], ['🎂', '💖']]
data.flatMap(extractEmojis) // => ['😘', '😁', '🎂', '💖']
```
