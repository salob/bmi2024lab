# bmi2024lab
BMI lab

For now there is just one branch and one github workflow to build, test and deploy.

Going forward I would have a separate ci workflow that just builds and runs tests that is triggered on every pr.

The build, test and publish then could be in a cd workflow that triggers on push to main
