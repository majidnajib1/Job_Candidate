'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');

var repo_root = __dirname + '/';
var govuk_frontend_toolkit_root = repo_root + 'node_modules/govuk_frontend_toolkit/stylesheets'; // 1.
var govuk_elements_sass_root = repo_root + 'node_modules/govuk-elements-sass/public/sass';       // 2.

// Compile scss files to css
gulp.task('styles', function () {
    return gulp.src('./Content/scss/**/*.scss')
      .pipe(sass({
          includePaths: [
            govuk_frontend_toolkit_root,
            govuk_elements_sass_root
          ]
      }).on('error', sass.logError))
      .pipe(gulp.dest('./Content/css'));
});
