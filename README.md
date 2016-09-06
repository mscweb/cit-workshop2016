# CIT Workshop

Sample repo for GitHub collaboration workshop

## Exercise

Fork this repo on GitHub

```
$ git clone [your-cit-workshop-fork]
$ cd [your-cit-workshop-fork]
$ git checkout -b [your-branch-name]
```

Within Visual Studio

Create a .json file within the Content directory with your own values

Sample .json file:

```
{
  "name": "Kyle",
  "adjective": "lazy",
  "noun": "Computer",
  "person": "Leonard Nimoy"
}

```

Edit the new file's properties and set Copy to Output Directory to Copy always.

Commit and Push your Changes

```
$ git status
$ git add MadLibs/MadLibs.csproj
$ git add MadLibs/Content/[your-new-filename].json
$ git commit -m "Added [your-filename]"
$ git push origin [your-branch]
```

Create Pull Request
