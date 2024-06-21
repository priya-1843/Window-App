import express from 'express';
import bodyParser from 'body-parser';
import * as fs from 'fs';

const app = express();
const port = 3000;

// Middleware to parse JSON bodies
app.use(bodyParser.json());

// Endpoint to always return true
app.get('/ping', (req, res) => {
    res.json(true);
});

// Endpoint to submit form data
app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;

    // Load existing submissions from db.json
    let submissions: any[] = [];
    try {
        const data = fs.readFileSync('db.json', 'utf8');
        submissions = JSON.parse(data);
    } catch (err) {
        console.error('Error reading db.json', err);
    }

    // Add new submission
    submissions.push({ name, email, phone, github_link, stopwatch_time });

    // Write updated submissions back to db.json
    fs.writeFile('db.json', JSON.stringify(submissions, null, 2), err => {
        if (err) {
            console.error('Error writing to db.json', err);
            res.status(500).json({ error: 'Failed to save submission' });
        } else {
            res.json({ message: 'Submission saved successfully' });
        }
    });
});

// Endpoint to read submission by index
app.get('/read', (req, res) => {
    const { index } = req.query;
    const idx = Number(index);

    // Load submissions from db.json
    try {
        const data = fs.readFileSync('db.json', 'utf8');
        const submissions = JSON.parse(data);

        // Check if index is valid
        if (idx >= 0 && idx < submissions.length) {
            res.json(submissions[idx]);
        } else {
            res.status(404).json({ error: 'Submission not found' });
        }
    } catch (err) {
        console.error('Error reading db.json', err);
        res.status(500).json({ error: 'Failed to read submissions' });
    }
});

// Start server
app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});
